using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Simulate
    {
        public void calculate()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(6);
            }
            sw.Stop();
            Console.WriteLine("the lepse time is :{0:\\hh\\:mm\\:ss}", sw.Elapsed);
        }
    }
}
