using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.ActorMessageTypes
{
    internal class RemoveKeyMessage
    {
        public RemoveKeyMessage(int hSMNo, string keyName)
        {
            HSMNo = hSMNo;
            KeyName = keyName;
        }

        public int HSMNo { get; private set; }
        public string KeyName { get; private set; }
    }
}
