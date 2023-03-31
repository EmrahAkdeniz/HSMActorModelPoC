using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.ActorMessageTypes
{
    internal class AddKeyMessage
    {
        public AddKeyMessage(int hSMNo, string keyName, byte[] value)
        {
            HSMNo = hSMNo;
            KeyName = keyName;
            Value = value;
        }

        public int HSMNo { get; private set; }
        public string KeyName { get; private set; }
        public byte[] Value { get; private set; }
    }
}
