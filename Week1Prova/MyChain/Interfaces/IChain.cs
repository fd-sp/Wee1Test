using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Prova.MyChain.Interfaces
{
    interface IChain
    {
        IChain SetNextInLine(IChain myChain);
        string Approve(int expense);
    }
}
