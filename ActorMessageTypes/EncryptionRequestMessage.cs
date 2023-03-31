using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.ActorMessageTypes
{
    internal class EncryptionRequestMessage
    {
        public EncryptionRequestMessage(int requestId, string keyName, string plainData)
        {
            RequestId = requestId;
            KeyName = keyName;
            PlainData = plainData;
        }

        public int RequestId { get; private set; }
        public string KeyName { get; private set; }
        public string PlainData { get; private set; }
    }
}
