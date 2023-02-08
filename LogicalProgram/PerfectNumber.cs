using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int div = 0;
            for(int i = 1; i < number; i++)
            {
                if(number % i == 0)
                {
                    div = div + i;
                }
            }
            if(number == div)
                Console.WriteLine("It Is a Perfect Number");
            else
                Console.WriteLine("It Is Not a Perfect Number");
        }
    }
}
