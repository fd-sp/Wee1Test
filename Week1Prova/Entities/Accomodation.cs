using System;
using System.Collections.Generic;
using System.Text;
using Week1Prova.Entities.Interfaces;

namespace Week1Prova.Entities
{
    class Accomodation : ICategorieSpesa
    {
        public double CategoryAssignment(int expense)
        {
            double result = Convert.ToDouble(expense);
            return result;
        }
    }
}
