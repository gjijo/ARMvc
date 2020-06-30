using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlkhalidUtility
{
    public enum ResponseCode
    {
        None = 0,
        Success = 1,
        InvalidSessionToken = 2,
        InvalidOldSessionToken = 3,
        SessionTokenExpired = 4,
        OldSessionTokenUsernameMismatch = 5,
        NoRecordFound = 6,
        IncorrectRechargeParty = 7,
        Failure = 99,
        Exception = 100
    }
}
