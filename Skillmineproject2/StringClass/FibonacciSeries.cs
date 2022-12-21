using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.StringClass
{
    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
             
            for (int i = 2; i < n; i++)
            {
                c = a + b;

                a = b;
                b = c;

                Console.WriteLine(c);
            }
        }
    }
}
