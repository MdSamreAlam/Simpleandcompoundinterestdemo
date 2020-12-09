using CalculateInterestDemo.Interfaceclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateInterestDemo
{
    /* 
COPY RIGHT @AUGMENTO LABS 2020
Created By Alam
    created abstract class
*/
    public abstract class Iabstract
    {
        public abstract  IfactoryInterest GetIfactoryInterest(string interest);

    }
    public class Concretefactory: Iabstract
    {
        public override IfactoryInterest GetIfactoryInterest(string interest)
        {
            switch (interest)
            {
                case "A": return new SimpleInterest();
                case "B": return new CompoundInterest();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
