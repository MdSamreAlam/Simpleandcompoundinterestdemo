using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int P, T;
            float R;
            Console.Write("Enter Amount :");
            P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate :");
            R = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Time :");
            T = Convert.ToInt32(Console.ReadLine());
            //SI = P * R * T / 100;
            FindInterest findInterest = new FindInterest();
            float result = findInterest.Interest(P, T, R);
            Console.WriteLine(result);
            //Console.WriteLine("Simple Interest is :{0}");
            Console.ReadKey();

        }
    }
    public class FindInterest
    {
        public float Interest(int P, int T, float R)
        {
            float s;
            s = P * R * T / 100;
            return s;
        }
    }
}
