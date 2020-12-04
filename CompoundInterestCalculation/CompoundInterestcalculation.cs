using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterestCalculation
{
    class CompoundInterestcalculation
    {
        static void Main(string[] args)
        {
            double amount;
            double interest;
            int years;
            // double balance = 0;

            Console.WriteLine("Enter the Amount");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Interest Rate");
            interest = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("Enter number of Years");
            years = Convert.ToInt32(Console.ReadLine());


            CompoundIntrest compoundIntrest = new CompoundIntrest();
            double results=  compoundIntrest.CalculateCompoundInterest(amount, interest, years);
           
                Console.WriteLine("Total Amount Balance is: {0}", results);
           
            Console.ReadLine();
        }
    }
    public class CompoundIntrest
    {
        public double CalculateCompoundInterest(double amount, double interest, int years)
        {
            double balance = 0;
            //int loop = 0;

            for (int i = 0; i <= years; i++)
            {
                balance = amount * Math.Pow((1 + interest), years);


            }
            return balance;

        }
    }

}
