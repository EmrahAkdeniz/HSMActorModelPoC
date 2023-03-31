using HSMActorModelPoC.HSMOperations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.HSMStats
{
    internal static class HsmClusterStats
    {
        private static List<HSMStat> _clusterStatsInstance = new List<HSMStat>();

        private static List<HSMKeyLastExecutionInfo> _lastKeyExecutorList = new List<HSMKeyLastExecutionInfo>();

        private static int _currentTPS;
        private static int _maxTPS;
        private static int _totalCommandCounterPerSecond;

        private static object _lock = new object();

        public static int MaxTPS { get => _maxTPS; set => _maxTPS = value; }
        public static int CurrentTPS { get => _currentTPS; set => _currentTPS = value; }

        public static int KeyARemainingCount { get; set; }
        public static int KeyBRemainingCount { get; set; }
        public static int KeyCRemainingCount { get; set; }

        static HsmClusterStats()
        {
            _lastKeyExecutorList.Add(new HSMKeyLastExecutionInfo() { KeyName = HSMKeys.KeyNameA });
            _lastKeyExecutorList.Add(new HSMKeyLastExecutionInfo() { KeyName = HSMKeys.KeyNameB });
            _lastKeyExecutorList.Add(new HSMKeyLastExecutionInfo() { KeyName = HSMKeys.KeyNameC });
        }

        public static void AddHSMStat(int hsmNo)
        {
            if (!_clusterStatsInstance.Any(h => h.HsmNo == hsmNo))
            {
                _clusterStatsInstance.Add(new HSMStat() { HsmNo = hsmNo });
            }
        }

        public static void RemoveHSMStat(int hsmNo)
        {
            var hsmStat = _clusterStatsInstance.FirstOrDefault(h => h.HsmNo == hsmNo);

            if (hsmStat != null)
            {
                _clusterStatsInstance.Remove(hsmStat);
            }
        }

        public static void UpdateHSMStat(int hsmNo, string hsmKeyName, int queuedMessageCount)
        {
            var hsmStat = _clusterStatsInstance.FirstOrDefault(h => h.HsmNo == hsmNo);

            if (hsmStat != null)
            {
                hsmStat.QueuedCommandCount = queuedMessageCount;
                hsmStat.ProcessedCommandCount++;
                hsmStat.CommandCounterPerSecond++;

                _totalCommandCounterPerSecond++;

                switch (hsmKeyName)
                {
                    case HSMKeys.KeyNameA:
                        KeyARemainingCount--;
                        break;
                    case HSMKeys.KeyNameB:
                        KeyBRemainingCount--;
                        break;
                    case HSMKeys.KeyNameC:
                        KeyCRemainingCount--;
                        break;
                }
            }
        }

        public static void SetLastExecutedHSM(int hsmNo, string hsmKeyName)
        {
            //Set last executed HSM for the given key
            var hsmKeyStat = _lastKeyExecutorList.FirstOrDefault(k => k.KeyName == hsmKeyName);
            if (hsmKeyStat != null) hsmKeyStat.LastExecutedHSMNo = hsmNo;
        }

        public static void AddKeyToHSMStat(int hsmNo, string keyName)
        {
            var hsmStat = _clusterStatsInstance.FirstOrDefault(h => h.HsmNo == hsmNo);

            if (hsmStat != null)
            {
                hsmStat.Keys.Add(keyName);
            }
        }

        public static void RemoveKeyFromHSMStat(int hsmNo, string keyName)
        {
            var hsmStat = _clusterStatsInstance.FirstOrDefault(h => h.HsmNo == hsmNo);

            if (hsmStat != null)
            {
                hsmStat.Keys.Remove(keyName);
            }
        }

        public static void ResetHSMStat(int hsmNo)
        {
            var hsmStat = _clusterStatsInstance.FirstOrDefault(h => h.HsmNo == hsmNo);
            if (hsmStat != null) hsmStat.Reset();
        }

        public static void ReselAllStats()
        {
            _totalCommandCounterPerSecond = 0;
            _maxTPS = 0;
            _currentTPS = 0;
            _lastKeyExecutorList.ForEach(k => k.LastExecutedHSMNo = 0);

            foreach (var hsmStat in _clusterStatsInstance)
            {
                hsmStat.Reset();
            }
        }

        public static int FindMostSuitableHSMForKeyCommandExecution(string key)
        {
            var lastExecutedHSMNo = _lastKeyExecutorList.FirstOrDefault(k => k.KeyName == key).LastExecutedHSMNo;

            //if the last executed HSM is the last HSM, set it to 0 to search from beginning
            if (lastExecutedHSMNo == _clusterStatsInstance.Count) lastExecutedHSMNo = 0;

            //Get the first available HSM with number greater than the last executed HSM number
            var hsmStat = _clusterStatsInstance.Where(h => h.Keys.Contains(key) && h.HsmNo > lastExecutedHSMNo).OrderBy(h => h.HsmNo).FirstOrDefault();

            //If there isn't one, get the HSM with the lowest number
            if (hsmStat == null) hsmStat = _clusterStatsInstance.Where(h => h.Keys.Contains(key)).OrderBy(h => h.HsmNo).FirstOrDefault();

            if (hsmStat != null) return hsmStat.HsmNo;
            else return 0;
        }

        public static void CalculateTPS()
        {
            CurrentTPS = _totalCommandCounterPerSecond;

            if (CurrentTPS > MaxTPS) MaxTPS = CurrentTPS;
            _totalCommandCounterPerSecond = 0;

            foreach (var hsmStat in _clusterStatsInstance)
            {
                hsmStat.CurrentLoadTPS = hsmStat.CommandCounterPerSecond;
                if(hsmStat.CurrentLoadTPS > hsmStat.MaxTPS) hsmStat.MaxTPS = hsmStat.CurrentLoadTPS;
                hsmStat.CommandCounterPerSecond = 0;
            }
        }

        public static HSMStat GetHSMStat(int hsmNo)
        {
            return _clusterStatsInstance.FirstOrDefault(h => h.HsmNo == hsmNo);
        }
    }
}
