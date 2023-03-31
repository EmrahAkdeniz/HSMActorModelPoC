using Akka.Actor;
using HSMActorModelPoC.ActorMessageTypes;
using HSMActorModelPoC.HSMOperations;
using HSMActorModelPoC.HSMStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.Actors
{
    internal class HSMCommandDispatcherActor : ReceiveActor
    {
        public HSMCommandDispatcherActor()
        {
            Receive<CreateHSMMessage>(createHSMRequest =>
            {
                var hsmActor = Context.ActorOf(Props.Create(() => new HSMActor(createHSMRequest.HSMNo)), "hsmno" + createHSMRequest.HSMNo);

                HsmClusterStats.AddHSMStat(createHSMRequest.HSMNo);

                HSMKeyStore.AddKey(createHSMRequest.HSMNo, HSMKeys.KeyNameA);
                HSMKeyStore.AddKey(createHSMRequest.HSMNo, HSMKeys.KeyNameB);
                HSMKeyStore.AddKey(createHSMRequest.HSMNo, HSMKeys.KeyNameC);

                Sender.Tell(new AckMessage(createHSMRequest.HSMNo, "OK") );
            });

            Receive<RemoveHSMMessage>(removeHSMRequest =>
            {
                var hsmActorSelector = Context.ActorSelection("hsmno" + removeHSMRequest.HSMNo);
                var actorTask = hsmActorSelector.ResolveOne(TimeSpan.FromSeconds(5));

                Context.Stop(actorTask.Result);

                HsmClusterStats.RemoveHSMStat(removeHSMRequest.HSMNo);

                Sender.Tell(new AckMessage(removeHSMRequest.HSMNo, "OK"));
            });

            Receive<EncryptionRequestMessage>(encryptionRequest =>
            {
                var hsmNo = HsmClusterStats.FindMostSuitableHSMForKeyCommandExecution(encryptionRequest.KeyName);

                if (hsmNo > 0)
                {
                    var hsmActorSelector = Context.ActorSelection("hsmno" + hsmNo);
                    hsmActorSelector.Tell(encryptionRequest);

                    HsmClusterStats.SetLastExecutedHSM(hsmNo, encryptionRequest.KeyName);
                }
            });

            Receive<StopAllOperationsMessage>(stopRequest =>
            {
                Context.Stop(Self);
                Context.ActorSelection("hsmno").Tell(stopRequest);
            });

            Receive<ErrorMessage>(errorRequest =>
            {
                //If a HSM actor does not have the key to encrypt data, pass the message to a suitable HSMActor.
                //We could resend to parent with EncryptionMessage but there can be optional operations at this time.
                if (errorRequest.Code == ErrorCode.HsmDoesNotHaveKeyToEncrypt && errorRequest.InnerMessage != null && errorRequest.InnerMessage is EncryptionRequestMessage)
                {
                    var encryptionMsg = errorRequest.InnerMessage as EncryptionRequestMessage;

                    var hsmActorList = Context.GetChildren();

                    var hsmNo = HsmClusterStats.FindMostSuitableHSMForKeyCommandExecution(encryptionMsg.KeyName);

                    if (hsmNo > 0)
                    {
                        var hsmActorSelector = Context.ActorSelection("hsmno" + hsmNo);
                        hsmActorSelector.Tell(encryptionMsg);
                    }
                }
            });
        }

        /*
        protected override void OnReceive(object message)
        {
            if (message is CreateHSMMessage)
            {
                var msg = (CreateHSMMessage)message;

                var hsmActor = Context.ActorOf(Props.Create(() => new HSMActor(msg.HSMNo)), "hsmno" + msg.HSMNo);

                HsmClusterStats.AddHSMStat(msg.HSMNo);

                HSMKeyStore.AddKey(msg.HSMNo, HSMKeys.KeyNameA);
                HSMKeyStore.AddKey(msg.HSMNo, HSMKeys.KeyNameB);
                HSMKeyStore.AddKey(msg.HSMNo, HSMKeys.KeyNameC);

                Context.Parent.Tell(new AckMessage() { Response = "OK" });
            }
            else if (message is RemoveHSMMessage)
            {
                var msg = (RemoveHSMMessage)message;

                var hsmActorSelector = Context.ActorSelection("hsmno" + msg.HSMNo);
                var actorTask = hsmActorSelector.ResolveOne(TimeSpan.FromSeconds(5));

                Context.Stop(actorTask.Result);

                HsmClusterStats.RemoveHSMStat(msg.HSMNo);

                Context.Parent.Tell(new AckMessage() { Response = "OK" });
            }
            else if (message is EncryptionMessage)
            {
                var msg = (EncryptionMessage)message;

                var hsmActorList = Context.GetChildren();

                var hsmNo = HsmClusterStats.FindMostSuitableHSMForKeyCommandExecution(msg.KeyName);

                if (hsmNo > 0)
                {
                    var hsmActorSelector = Context.ActorSelection("hsmno" + hsmNo);
                    hsmActorSelector.Tell(msg);

                    HsmClusterStats.SetLastExecutedHSM(hsmNo, msg.KeyName);
                }
            }
            else if (message is StopAllOperationsMessage)
            {
                Context.Stop(Self);
                Context.ActorSelection("hsmno").Tell(message);
            }
            else if (message is ErrorMessage)
            {
                var msg = (ErrorMessage)message;

                //If a HSM actor does not have the key to encrypt data, pass the message to a suitable HSMActor
                if (msg.Code == ErrorCode.HsmDoesNotHaveKeyToEncrypt && msg.InnerMessage != null && msg.InnerMessage is EncryptionMessage)
                {
                    var encryptionMsg = msg.InnerMessage as EncryptionMessage;

                    var hsmActorList = Context.GetChildren();

                    var hsmNo = HsmClusterStats.FindMostSuitableHSMForKeyCommandExecution(encryptionMsg.KeyName);

                    if (hsmNo > 0)
                    {
                        var hsmActorSelector = Context.ActorSelection("hsmno" + hsmNo);
                        hsmActorSelector.Tell(encryptionMsg);
                    }
                }
            }
        }
        */
    }
}
