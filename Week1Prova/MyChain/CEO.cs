using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Prova.MyChain
{
    class CEO : AbstractApproval
    {
        public override string Approve(int expense)
        {
            if (expense>1000 && expense <= 2500)
                return "APPROVATA;CEO;";
            return "RESPINTA;-;-";
        }
    }
}
