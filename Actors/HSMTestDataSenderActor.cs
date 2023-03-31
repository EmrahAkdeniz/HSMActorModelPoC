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
    internal class HSMTestDataSenderActor : ReceiveActor
    {
        public HSMTestDataSenderActor()
        {
            Receive<HSMTestDataSenderMessage>(hsmTestDataSenderRequest =>
            {
                var sampleClearText = "Sample text to encrypt.Sample text to encrypt.Sample text to encrypt.Sample text to encrypt.";

                HsmClusterStats.KeyARemainingCount = hsmTestDataSenderRequest.KeyADataCount;
                HsmClusterStats.KeyBRemainingCount = hsmTestDataSenderRequest.KeyBDataCount;
                HsmClusterStats.KeyCRemainingCount = hsmTestDataSenderRequest.KeyCDataCount;

                var requestId = 1;

                var dispatcherActor = Context.ActorSelection("/user/hsmcommanddispatcher");

                for (int i = 0; i < hsmTestDataSenderRequest.KeyADataCount; i++)
                {
                    dispatcherActor.Tell(new EncryptionRequestMessage(requestId, HSMKeys.KeyNameA, sampleClearText));

                    requestId++;
                }

                for (int i = 0; i < hsmTestDataSenderRequest.KeyBDataCount; i++)
                {
                    dispatcherActor.Tell(new EncryptionRequestMessage(requestId, HSMKeys.KeyNameB, sampleClearText));


                    requestId++;
                }

                for (int i = 0; i < hsmTestDataSenderRequest.KeyCDataCount; i++)
                {
                    dispatcherActor.Tell(new EncryptionRequestMessage(requestId, HSMKeys.KeyNameC, sampleClearText));


                    requestId++;
                }
            });
        }

        /*
        protected override void OnReceive(object message)
        {
            if (message is HSMTestDataSenderMessage)
            {
                var msg = (HSMTestDataSenderMessage)message;

                var sampleClearText = "Sample text to encrypt.Sample text to encrypt.Sample text to encrypt.Sample text to encrypt.";

                HsmClusterStats.KeyARemainingCount = msg.KeyADataCount;
                HsmClusterStats.KeyBRemainingCount = msg.KeyBDataCount;
                HsmClusterStats.KeyCRemainingCount = msg.KeyCDataCount;

                var requestId = 1;

                var dispatcherActor = Context.ActorSelection("/user/hsmcommanddispatcher");

                for (int i = 0; i < msg.KeyADataCount; i++)
                {
                    dispatcherActor.Tell(
                        new EncryptionMessage()
                        {
                            KeyName = HSMKeys.KeyNameA,
                            PlainData = sampleClearText,
                            RequestId = requestId
                        });

                    requestId++;
                }

                for (int i = 0; i < msg.KeyBDataCount; i++)
                {
                    dispatcherActor.Tell(
                        new EncryptionMessage()
                        {
                            KeyName = HSMKeys.KeyNameB,
                            PlainData = sampleClearText,
                            RequestId = requestId
                        });

                    requestId++;
                }

                for (int i = 0; i < msg.KeyCDataCount; i++)
                {
                    dispatcherActor.Tell(
                        new EncryptionMessage()
                        {
                            KeyName = HSMKeys.KeyNameC,
                            PlainData = sampleClearText,
                            RequestId = requestId
                        });

                    requestId++;
                }
            }
        }
        */
    }
}
