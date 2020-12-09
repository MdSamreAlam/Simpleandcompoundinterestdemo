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
    public class SimpleInterest:IfactoryInterest
    {
      public  double Interest(double amount, double interest, int years, int annualfrequency = 0)
        {
            double result;
            // Formula used to calculate interest
            result = amount * interest * years;
            
            return result;
        }
    }
}
