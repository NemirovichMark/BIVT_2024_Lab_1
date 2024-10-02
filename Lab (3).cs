using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            double S = 0, x = 2, y = 1;
            while (Math.Abs(y)>= 0.0001)
            {
                y = Math.Cos(n * y) / n;
                S += y;
                Console.WriteLine($"{n,10}{y,10:f5}{S,10:f5}");
                n++;
                
            }

            S = Math.Round(S, 2);
            Console.WriteLine($"{n,10}{x,10:f5}{S,10:f5}");
            Console.ReadKey();

        }
    }
}
