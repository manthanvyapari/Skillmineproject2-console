using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2
{
    class Outkey
    {

        static void Calc(int a, int b, out int sum, out int sub, out int multiply)
        {
            sum = a + b;
            sub = a - b;
            multiply = a * b;
        }
        static void Main(string[] args)
        {
            int a = 44, b = 23, sum, sub, mul;
            Calc(a, b, out sum, out sub, out mul); // no values 
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);


            a = 10; b = 12;

            Calc(a, b, out sum, out sub, out mul); // no values 
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);

        }



    }
}
