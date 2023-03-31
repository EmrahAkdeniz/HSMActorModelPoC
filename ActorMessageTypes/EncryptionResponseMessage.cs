using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.ActorMessageTypes
{
    internal class EncryptionResponseMessage
    {
        public EncryptionResponseMessage(int requestId, int hSMNo, string keyName, string plainData, string encryptedData, int queuedCommandCount)
        {
            RequestId = requestId;
            HSMNo = hSMNo;
            KeyName = keyName;
            PlainData = plainData;
            EncryptedData = encryptedData;
            QueuedCommandCount = queuedCommandCount;
        }

        public int RequestId { get; private set; }
        public int HSMNo { get; private set; }
        public string KeyName { get; private set; }
        public string PlainData { get; private set; }
        public string EncryptedData { get; private set; }
        public int QueuedCommandCount { get; private set; }
    }
}
