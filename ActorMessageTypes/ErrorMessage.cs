using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMActorModelPoC.ActorMessageTypes
{
    internal class ErrorMessage
    {
        public ErrorMessage(int hSMNo, ErrorCode code, string message, object innerMessage)
        {
            HSMNo = hSMNo;
            Code = code;
            Message = message;
            InnerMessage = innerMessage;
        }

        public int HSMNo { get; private set; }
        public ErrorCode Code { get; private set; }

        public string Message { get; private set; }

        public object InnerMessage { get; private set; }
    }

    public enum ErrorCode
    {
        HsmAlreadyHasKeyToAdd = 1,
        HsmDoesNotHaveKeyToRemove = 2,
        HsmDoesNotHaveKeyToEncrypt = 3,
        HsmDoesNotHaveKeyToDecrypt = 4,

    }
}
