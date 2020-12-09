using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateInterestDemo.Interfaceclass;

namespace CalculateInterestDemo
{
    /* 
COPY RIGHT @AUGMENTO LABS 2020
Created By Alam
*/
    public class CompoundInterest:IfactoryInterest
    {
       public double Interest(double amount, double interest, int years, int annualfrequency = 0)
        {
            double balance;

            // Formulae use to calculate compound interest
            balance = amount * Math.Pow((1 + interest / annualfrequency), years * annualfrequency);
            return balance;

        }
    }
}
