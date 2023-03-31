using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.HSMOperations
{
    internal class HSMKeys
    {
        public const string KeyNameA = "A";
        public const string KeyNameB = "B";
        public const string KeyNameC = "C";

        public static readonly byte[] KeyA = Convert.FromHexString("4D635166546A576E5A7234753778214125442A472D4B614E645267556B587032");
        public static readonly byte[] KeyB = Convert.FromHexString("6E327235753778214125442A472D4B6150645367566B59703373367639792F42");
        public static readonly byte[] KeyC = Convert.FromHexString("556A586E3272357538782F413F4428472D4B6150645367566B59703373367639");

        public static byte[] GetKey(string KeyName)
        {
            switch (KeyName)
            {
                case KeyNameA:
                    return KeyA;
                case KeyNameB:
                    return KeyB;
                case KeyNameC:
                    return KeyC;
                default:
                    return null;
            }
        }
    }
}
