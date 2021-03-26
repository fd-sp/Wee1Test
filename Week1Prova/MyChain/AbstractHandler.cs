using System;
using System.Collections.Generic;
using System.Text;
using Week1Prova.MyChain.Interfaces;

namespace Week1Prova.MyChain
{
    abstract class AbstractApproval : IChain
    {
        private IChain NextInLine;

        public IChain SetNextInLine(IChain myChain)
        {
            NextInLine = myChain;
            return NextInLine;
        }

        public virtual string Approve(int expense)
        {
            if (this.NextInLine != null)
                return this.NextInLine.Approve(expense);
            return null;
        }
    }
}
