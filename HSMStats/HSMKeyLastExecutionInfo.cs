using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.HSMStats
{
    internal class HSMKeyLastExecutionInfo
    {
        public string KeyName { get; set; }
        public int LastExecutedHSMNo { get; set; }
    }
}
