using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.ActorMessageTypes
{
    internal class CreateHSMMessage
    {
        public CreateHSMMessage(int hSMNo)
        {
            HSMNo = hSMNo;
        }

        public int HSMNo { get; private set; }
    }
}
