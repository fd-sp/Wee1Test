using System;
using System.Collections.Generic;
using System.Text;
using Week1Prova.Entities.Interfaces;
using Week1Prova.Entities;

namespace Week1Prova
{
    public class MyFactory
    {
        public static double ExpenseFactory(string categoria, int expense)
        {
            ICategorieSpesa catSpesa;
            if (categoria.Trim().ToLower().Equals("viaggio"))
            {
                catSpesa = new Travel();
                return catSpesa.CategoryAssignment(expense);
            }
            else if (categoria.Trim().ToLower().Equals("alloggio"))
            {
                catSpesa = new Accomodation();
                return catSpesa.CategoryAssignment(expense);
            }
            else if (categoria.Trim().ToLower().Equals("vitto"))
            {
                catSpesa = new Food();
                return catSpesa.CategoryAssignment(expense);
            }
            else if(categoria.Trim().ToLower().Equals("altro"))
            {
                catSpesa = new Other();
                return catSpesa.CategoryAssignment(expense);
            }
            return -1.0;
        }
    }
}
