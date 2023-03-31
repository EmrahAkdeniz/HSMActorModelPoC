using Akka.Actor;
using HSMActorModelPoC.ActorMessageTypes;
using HSMActorModelPoC.HSMOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.Actors
{
    internal class HSMActor : ReceiveActor
    {
        private int _hsmNumber;

        public HSMActor(int HSMNumber)
        {
            _hsmNumber = HSMNumber;

            Receive<EncryptionRequestMessage>(encryptionRequest =>
            {
                var key = HSMKeyStore.GetKey(_hsmNumber, encryptionRequest.KeyName);

                if (key != null)
                {
                    var encryptedData = Encryptor.EncryptWithKey(key, encryptionRequest.PlainData);

                    var encryptionResponse = new EncryptionResponseMessage
                    (
                        encryptionRequest.RequestId,
                        _hsmNumber, 
                        encryptionRequest.KeyName, 
                        encryptionRequest.PlainData, 
                        encryptedData, 
                        (Context as ActorCell).Mailbox.MessageQueue.Count
                        );

                    var hsmStatsActor = Context.ActorSelection("/user/hsmresultcollector");
                    hsmStatsActor.Tell(encryptionResponse);
                }
                else
                {
                    Context.Parent.Tell(
                        new ErrorMessage(
                            _hsmNumber,
                            ErrorCode.HsmDoesNotHaveKeyToEncrypt,
                            String.Format("HSM #{0} does not have the key '{1}' to encrypt data.", _hsmNumber, encryptionRequest.KeyName),
                            encryptionRequest));
                        
                }
            });

            Receive<StopAllOperationsMessage>(stopRequest =>
            {
                Context.Stop(Self);
            });
        }

        /*
        protected override void OnReceive(object message)
        {
            if (message is EncryptionMessage)
            {
                var msg = (EncryptionMessage)message;

                var key = HSMKeyStore.GetKey(_hsmNumber, msg.KeyName);

                if (key != null)
                {
                    var encryptedData = Encryptor.EncryptWithKey(key, msg.PlainData);

                    msg.QueuedCommandCount = (Context as ActorCell).Mailbox.MessageQueue.Count;
                    msg.EncryptedData = encryptedData;
                    msg.HSMNo = _hsmNumber;

                    var hsmStatsActor = Context.ActorSelection("/user/hsmstats");
                    hsmStatsActor.Tell(msg);
                }
                else
                {
                    Context.Parent.Tell(
                        new ErrorMessage()
                        {
                            HSMNo = _hsmNumber,
                            Code = ErrorCode.HsmDoesNotHaveKeyToEncrypt,
                            Message = String.Format("HSM #{0} does not have the key '{1}' to encrypt data.", _hsmNumber, msg.KeyName),
                            InnerMessage = msg
                        });
                }
            }
            else if (message is StopAllOperationsMessage)
            {
                Context.Stop(Self);
            }
        }
        */
    }
}
