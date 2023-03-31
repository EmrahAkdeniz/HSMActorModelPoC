using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.ActorMessageTypes
{
    internal class AckMessage
    {
        public AckMessage(int hSMNo, string response)
        {
            HSMNo = hSMNo;
            Response = response;
        }

        public int HSMNo { get; private set; }
        public string Response { get; private set; }

    }
}
