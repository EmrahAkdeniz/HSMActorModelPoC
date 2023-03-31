using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using HSMActorModelPoC.ActorMessageTypes;
using HSMActorModelPoC.HSMStats;

namespace HSMActorModelPoC.Actors
{
    internal class HSMResultCollectorActor : ReceiveActor
    {
        public HSMResultCollectorActor()
        {
            Receive<EncryptionResponseMessage>(encryptionResponse =>
            {
                HsmClusterStats.UpdateHSMStat(encryptionResponse.HSMNo, encryptionResponse.KeyName, encryptionResponse.QueuedCommandCount);
            });
        }

        /*
        protected override void OnReceive(object message)
        {
            if (message is EncryptionMessage)
            {
                var msg = (EncryptionMessage)message;
                var processedCommandCount = HsmClusterStats.UpdateHSMStat(msg.HSMNo, msg.KeyName, msg.QueuedCommandCount);
            }
        }
        */
    }
}
