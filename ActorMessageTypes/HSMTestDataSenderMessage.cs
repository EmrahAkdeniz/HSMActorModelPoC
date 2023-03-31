using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.ActorMessageTypes
{
    internal class HSMTestDataSenderMessage
    {
        public HSMTestDataSenderMessage(int keyADataCount, int keyBDataCount, int keyCDataCount)
        {
            KeyADataCount = keyADataCount;
            KeyBDataCount = keyBDataCount;
            KeyCDataCount = keyCDataCount;
        }

        public int KeyADataCount { get; private set; }
        public int KeyBDataCount { get; private set; }
        public int KeyCDataCount { get; private set; }
    }
}
