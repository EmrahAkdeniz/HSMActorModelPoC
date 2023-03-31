using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.ActorMessageTypes
{
    internal class RemoveHSMMessage
    {
        public RemoveHSMMessage(int hSMNo)
        {
            HSMNo = hSMNo;
        }

        public int HSMNo { get; private set; }
    }
}
