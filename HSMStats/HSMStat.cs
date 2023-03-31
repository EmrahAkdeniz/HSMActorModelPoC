using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.HSMStats
{
    internal class HSMStat
    {
        public int HsmNo;
        public List<string> Keys = new List<string>();
        public int QueuedCommandCount;
        public int ProcessedCommandCount;
        public int CurrentLoadTPS;
        public int MaxTPS;
        public int CommandCounterPerSecond;

        public void Reset()
        {
            CommandCounterPerSecond = 0;
            QueuedCommandCount = 0;
            ProcessedCommandCount = 0;
            CurrentLoadTPS = 0;
            MaxTPS = 0;
        }
    }
}
