using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Prova.MyChain
{
    class OperationalManager : AbstractApproval
    {
        public override string Approve(int expense)
        {
            if (expense>400 && expense <= 1000)
                return "APPROVATA;OperationalManager;";
            return base.Approve(expense);
        }
    }
}
