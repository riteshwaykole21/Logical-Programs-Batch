using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : FibonacciSeries\n 2: PerfectNumber\n 3:Prime Number\n 4:Reverse Number\n 5:Coupon Number\n 6:Stop Watch");
            Console.WriteLine("Enter a Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    FibonacciSeries Num = new FibonacciSeries();
                    Num.Series();
                    break;  
                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.Perfect();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime();
                    break;
                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.Reverse();
                    break;
                case 5:
                    CouponNumber couponNumber = new CouponNumber();
                    couponNumber.RandomCouponNumber();
                    break;
                case 6:
                    Simulate obj = new Simulate();
                    obj.calculate();
                    break;
            }
            Console.ReadLine();
        }
    }
}
