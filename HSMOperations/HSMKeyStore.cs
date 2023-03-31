using HSMActorModelPoC.HSMStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.HSMOperations
{
    internal static class HSMKeyStore
    {
        private static Dictionary<int, Dictionary<string, byte[]>> mKeyStore = new Dictionary<int, Dictionary<string, byte[]>>();

        public static void AddKey(int hsmNo, string hsmKey)
        {
            if (!mKeyStore.ContainsKey(hsmNo)) mKeyStore.Add(hsmNo, new Dictionary<string, byte[]>());

            var hsmKeyRows = mKeyStore[hsmNo];

            hsmKeyRows[hsmKey] = HSMKeys.GetKey(hsmKey);

            HsmClusterStats.AddKeyToHSMStat(hsmNo, hsmKey);
        }

        public static void RemoveKey(int hsmNo, string hsmKey)
        {
            if (mKeyStore.ContainsKey(hsmNo))
            {
                var hsmKeyRows = mKeyStore[hsmNo];

                if (hsmKeyRows != null)
                {
                    hsmKeyRows.Remove(hsmKey);
                }

                HsmClusterStats.RemoveKeyFromHSMStat(hsmNo, hsmKey);
            }
        }

        public static byte[] GetKey(int hsmNo, string hsmKey)
        {
            if (mKeyStore.ContainsKey(hsmNo))
            {
                var hsmKeyRows = mKeyStore[hsmNo];

                if (hsmKeyRows != null && hsmKeyRows.ContainsKey(hsmKey))
                {
                    return hsmKeyRows[hsmKey];
                }
            }

            return null;
        }

        public static void RemoveHSMKeys(int hsmNo)
        {
            if (mKeyStore.ContainsKey(hsmNo))
            {
                mKeyStore.Remove(hsmNo);
            }
        }
    }
}
