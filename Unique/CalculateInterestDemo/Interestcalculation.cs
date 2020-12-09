using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateInterestDemo.Interfaceclass;
using CalculateInterestDemo;

namespace CalculateInterestDemo
{
    /* 
COPY RIGHT @AUGMENTO LABS 2020
Created By Alam
*/
    class Interestcalculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose which Intrest to Calculate");
            Console.WriteLine("i)SimpleIntrest-->1");
            Console.WriteLine("ii)CompoundIntrest-->2");

            Concretefactory CalculateSi = new Concretefactory();

            var selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                int years;
                float rateOfIntrest;
                double amount;

                Console.WriteLine("Enter principal Amount:");
                amount = double.Parse(Console.ReadLine());

                Console.Write("Enter the rate of interest : ");
                rateOfIntrest = float.Parse(Console.ReadLine()) / 100;

                Console.Write("Enter the total number of years : ");
                years = int.Parse(Console.ReadLine());

                IfactoryInterest SimpleIntrest = CalculateSi.GetIfactoryInterest("A");
                var Result = SimpleIntrest.Interest(amount,rateOfIntrest,years);
                Console.Write("Simple Intrest is " + Result);
            }
            else if (selection == 2)
            {
                double amount; 
                double interest;
                int years;
                int annualCompound;
                Console.WriteLine("Enter principal Amount:");
                amount = double.Parse(Console.ReadLine());

                Console.Write("Enter the rate of interest : ");
                interest = double.Parse(Console.ReadLine()) / 100;

                Console.Write("Enter the total number of years : ");
                years = int.Parse(Console.ReadLine());

                Console.Write("Compounding frequency quarterly or monthly : ");
                annualCompound = int.Parse(Console.ReadLine());

                IfactoryInterest CalculateCi = CalculateSi.GetIfactoryInterest("B");
                var Result = CalculateCi.Interest(amount, interest, years, annualCompound);
                Console.Write("After " + years + " years there will be a " + Result + " in the Account");

            }
            Console.ReadKey();


        }
    }
   
    
}
