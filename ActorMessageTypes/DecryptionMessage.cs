using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.ActorMessageTypes
{
    internal class DecryptionMessage
    {
        public DecryptionMessage(int requestId, int hSMNo, string keyName, string encryptedData, string plainData)
        {
            RequestId = requestId;
            HSMNo = hSMNo;
            KeyName = keyName;
            EncryptedData = encryptedData;
            PlainData = plainData;
        }

        public int RequestId { get; private set; }
        public int HSMNo { get; private set; }
        public string KeyName { get; private set; }
        public string EncryptedData { get; private set; }
        public string PlainData { get; private set; }
    }
}
