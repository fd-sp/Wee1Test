using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Prova.MyChain
{
    class Manager : AbstractApproval
    {
        public override string Approve(int expense)
        {
            if (expense<=400)
                return "APPROVATA;Manager;";
            return base.Approve(expense);
        }
    }
}
