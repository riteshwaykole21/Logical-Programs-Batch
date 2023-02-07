using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class FibonacciSeries
    {
        public void Series()
        {
            int A = 0;
            int B = 1;
            int C;
            int D;
            Console.WriteLine("Enter The Number To Extent Fibonacci Series");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci Series"+" ");
            Console.Write(A +" "+ B +" ");
            
            for (int i = 3;i <= Num;i++)
            {
                C = B + A;
                Console.Write(C+" ");
                A = B;
                B = C;
            }
        }
    }
}
