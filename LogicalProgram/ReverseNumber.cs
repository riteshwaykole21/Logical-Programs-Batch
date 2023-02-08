using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter A Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int rem;
            while(number > 0)
            {
                rem = number % 10;
                result = result * 10 + rem;
                number = number / 10;   
            }
            Console.WriteLine("Reverse number Is = " + result);
        }
    }
}
