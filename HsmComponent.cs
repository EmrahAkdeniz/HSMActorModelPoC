using HSMActorModelPoC.HSMOperations;
using System.Data;
using HSMActorModelPoC.HSMStats;

namespace HSMActorModelPoC
{
    public partial class HsmComponent : UserControl
    {
        #region Props

        private int _number;
        public int Number { get { return _number; } }
        public int QueuedCommandCount { set { txtQueuedCount.Text = value.ToString(); } }
        public int ProcessedCommandCount { set { txtProcessedCount.Text = value.ToString(); } }
        public int LoadTps { set { txtLoadTPS.Text = value.ToString(); } }
        public int MaxTps { set { txtMaxTPS.Text = value.ToString(); } }

        public List<string> Keys { get { return lstCurKeys.Items.Cast<string>().ToList(); } }

        #endregion

        #region Constructors

        public HsmComponent()
        {
            InitializeComponent();
        }

        public HsmComponent(int number)
        {
            InitializeComponent();

            _number = number;

            grpHSM.Text = "HSM #" + _number;

            this.grpHSM.BackColor = Color.LightBlue;
        }

        #endregion

        #region Events

        private void lnkLblAddKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var selectedKeyToAdd = lstKeys.SelectedItem as string;

            if (selectedKeyToAdd != null && !lstCurKeys.Items.Contains(selectedKeyToAdd))
            {
                int index = 0;

                for (index = 0; index < lstCurKeys.Items.Count; index++)
                {
                    var item = lstCurKeys.Items[index];
                    if (item == null || item.ToString().CompareTo(selectedKeyToAdd) > 0) break;
                }

                lstCurKeys.Items.Insert(index, selectedKeyToAdd);

                HSMKeyStore.AddKey(_number, selectedKeyToAdd);
            }
        }

        private void lnkLblDelKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lstCurKeys.SelectedItem is not null)
            {
                var key = lstCurKeys.SelectedItem as string;

                lstCurKeys.Items.Remove(lstCurKeys.SelectedItem);

                HSMKeyStore.RemoveKey(_number, key);

                if (lstCurKeys.Items.Count > 0) lstCurKeys.SelectedIndex = lstCurKeys.Items.Count - 1;
            }
        }

        #endregion

        #region Methods

        public void SetTPS()
        {
            var hsmStat = HsmClusterStats.GetHSMStat(_number);

            if (hsmStat != null)
            {
                QueuedCommandCount = hsmStat.QueuedCommandCount;
                ProcessedCommandCount = hsmStat.ProcessedCommandCount;
                txtLoadTPS.Text = hsmStat.CurrentLoadTPS.ToString();
                txtMaxTPS.Text = hsmStat.MaxTPS.ToString();
            }
        }

        #endregion

    }
}
