using Akka.Actor;
using HSMActorModelPoC.ActorMessageTypes;
using HSMActorModelPoC.Actors;
using HSMActorModelPoC.HSMOperations;
using HSMActorModelPoC.HSMStats;
using Net.Pkcs11Interop.Common;
using Net.Pkcs11Interop.HighLevelAPI;
using Net.Pkcs11Interop.HighLevelAPI.Factories;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HSMActorModelPoC
{
    public partial class FrmMain : Form
    {
        #region Props

        public static ActorSystem HSMActorSystem;
        public static IActorRef HSMCmdDispatcherActor;
        public static IActorRef HSMResultCollectorActor;
        public static IActorRef HSMTestDataSenderActor;
        public static Pkcs11InteropFactories Factories = new Pkcs11InteropFactories();
        public const string Pkcs11LibraryPath = @"C:\Program Files (x86)\SafeNet\Protect Toolkit C SDK\bin\sw\cryptoki.dll";

        private Stopwatch _swDuration;

        private List<HsmComponent> _hsmComponentList = new List<HsmComponent>();

        #endregion

        #region Constructor

        public FrmMain()
        {
            InitializeComponent();

            HSMActorSystem = ActorSystem.Create("hsmactorsystem");
            HSMCmdDispatcherActor = HSMActorSystem.ActorOf(Props.Create(() => new HSMCommandDispatcherActor()), "hsmcommanddispatcher");
            HSMResultCollectorActor = HSMActorSystem.ActorOf(Props.Create(() => new HSMResultCollectorActor()), "hsmresultcollector");
            HSMTestDataSenderActor = HSMActorSystem.ActorOf(Props.Create(() => new HSMTestDataSenderActor()), "hsmtestdatasender");

            pnlHSMList.Controls.Clear();
            HsmClusterStats.ReselAllStats();
            AddDefaultHSMs();
            _swDuration = new Stopwatch();
        }

        #endregion

        #region Events

        private void neHSMCount_ValueChanged(object sender, EventArgs e)
        {
            if (neHSMCount.Value > _hsmComponentList.Count)
            {
                var hsmNumber = Convert.ToInt32(neHSMCount.Value);
                AddHSM(hsmNumber);
            }
            else
            {
                var lastHSMComponent = _hsmComponentList.Last();
                RemoveHSM(lastHSMComponent);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtDuration.Text = "";

            btnStart.Enabled = false;

            neARemainingCount.Value = neACount.Value;
            neBRemainingCount.Value = neBCount.Value;
            neCRemainingCount.Value = neCCount.Value;

            neACount.Enabled = false;
            neBCount.Enabled = false;
            neCCount.Enabled = false;

            ResetHSMComponentData();
            HsmClusterStats.ReselAllStats();

            neCurrentTPS.Value = 0;
            neMaxTPS.Value = 0;

            _swDuration.Start();
            tmrTPS.Start();
            tmrDuration.Start();
            neHSMCount.Focus();

            SendBatchDataToHSMViaActorModel();
        }

        private void neACount_ValueChanged(object sender, EventArgs e)
        {
            neARemainingCount.Value = neACount.Value;
        }

        private void neBCount_ValueChanged(object sender, EventArgs e)
        {
            neBRemainingCount.Value = neBCount.Value;
        }

        private void neCCount_ValueChanged(object sender, EventArgs e)
        {
            neCRemainingCount.Value = neCCount.Value;
        }

        private void tmrTPS_Tick(object sender, EventArgs e)
        {
            CalculateTPS();
        }

        private void tmrDuration_Tick(object sender, EventArgs e)
        {
            PrintDuration();

            neARemainingCount.Value = HsmClusterStats.KeyARemainingCount;
            neBRemainingCount.Value = HsmClusterStats.KeyBRemainingCount;
            neCRemainingCount.Value = HsmClusterStats.KeyCRemainingCount;

            if (neARemainingCount.Value == 0 && neBRemainingCount.Value == 0 && neCRemainingCount.Value == 0)
            {
                tmrTPS.Stop();
                tmrDuration.Stop();
                _swDuration.Stop();

                _swDuration.Reset();

                btnStart.Enabled = true;

                neACount.Enabled = true;
                neBCount.Enabled = true;
                neCCount.Enabled = true;

                CalculateTPS();
            }
        }

        private void btnHSMTest_Click(object sender, EventArgs e)
        {
            try
            {
                using (IPkcs11Library pkcs11Library = Factories.Pkcs11LibraryFactory.LoadPkcs11Library(Factories, Pkcs11LibraryPath, AppType.MultiThreaded))
                {
                    List<ISlot> slots = pkcs11Library.GetSlotList(SlotsType.WithTokenPresent);

                    // Open RW session
                    using (ISession session = slots[0].OpenSession(SessionType.ReadWrite))
                    {
                        // Login as normal user
                        session.Login(CKU.CKU_USER, "123456");

                        List<IObjectAttribute> objectAttributes = new List<IObjectAttribute>();
                        objectAttributes.Add(session.Factories.ObjectAttributeFactory.Create(CKA.CKA_LABEL, "MASTER"));

                        // Find all objects that match provided attributes
                        List<IObjectHandle> foundObjects = session.FindAllObjects(objectAttributes);

                        IMechanism mechanism = session.Factories.MechanismFactory.Create(CKM.CKM_AES_CBC);

                        var key = foundObjects[0];

                        byte[] sourceData = ConvertUtils.Utf8StringToBytes("Our new password");

                        // Encrypt data
                        byte[] encryptedData = session.Encrypt(mechanism, key, sourceData);

                        // Do something interesting with encrypted data

                        // Decrypt data
                        byte[] decryptedData = session.Decrypt(mechanism, key, encryptedData);

                        session.Logout();

                        if (ConvertUtils.BytesToUtf8String(decryptedData) == "Our new password")
                        {
                            MessageBox.Show("HSM is operational");
                        }
                        else
                        {
                            MessageBox.Show("HSM is not fully operational.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("HSM is not fully operational.");
            }
        }

        #endregion

        #region Methods

        private void ResetHSMComponentData()
        {
            foreach (var hsmComponent in _hsmComponentList)
            {
                hsmComponent.QueuedCommandCount = 0;
                hsmComponent.ProcessedCommandCount = 0;
                hsmComponent.LoadTps = 0;
                hsmComponent.MaxTps = 0;
            }
        }

        private void AddHSM(int hsmNumber)
        {
            var hsmComponent = new HsmComponent(hsmNumber);
            hsmComponent.Location = GetHSMComponentLocation(hsmNumber);
            pnlHSMList.Controls.Add(hsmComponent);
            _hsmComponentList.Add(hsmComponent);

            HSMCmdDispatcherActor.Tell(new CreateHSMMessage(hsmNumber));
        }

        private void RemoveHSM(HsmComponent lastHSMComponent)
        {
            var hsmNumber = lastHSMComponent.Number;
            pnlHSMList.Controls.Remove(lastHSMComponent);
            _hsmComponentList.Remove(lastHSMComponent);
            HSMCmdDispatcherActor.Tell(new RemoveHSMMessage(hsmNumber));
            HsmClusterStats.RemoveHSMStat(hsmNumber);
            HSMKeyStore.RemoveHSMKeys(hsmNumber);
        }

        private Point GetHSMComponentLocation(int number)
        {
            var xOrder = (_hsmComponentList.Count) % 4;
            var yOrder = (_hsmComponentList.Count) / 4;

            int x = xOrder * 203 + 6, y = yOrder * 251 + 6;

            return new Point(x, y);
        }

        private void SendBatchDataToHSMViaActorModel()
        {
            var keyADataCount = Convert.ToInt32(neACount.Value);
            var keyBDataCount = Convert.ToInt32(neBCount.Value);
            var keyCDataCount = Convert.ToInt32(neCCount.Value);

            HSMTestDataSenderActor.Tell(new HSMTestDataSenderMessage(keyADataCount, keyBDataCount, keyCDataCount));
        }

        private void CalculateTPS()
        {
            HsmClusterStats.CalculateTPS();

            neCurrentTPS.Value = HsmClusterStats.CurrentTPS;
            neMaxTPS.Value = HsmClusterStats.MaxTPS;

            _hsmComponentList.ForEach(h =>
            {
                h.SetTPS();
            });
        }

        private void PrintDuration()
        {
            txtDuration.Text = (_swDuration.ElapsedMilliseconds / 1000) + "." + _swDuration.ElapsedMilliseconds % 100;
        }

        private void AddDefaultHSMs()
        {
            AddHSM(1);
            AddHSM(2);
            AddHSM(3);
            AddHSM(4);
        }

        #endregion

    
    }
}