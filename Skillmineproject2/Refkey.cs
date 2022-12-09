using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2
{
   public class Refkey
    {
        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before call the method a={a},b={b}");
            Swap(ref a, ref b);//reffrence add
            Console.WriteLine($"after call the methoda a={a},b={b}");
        }
    }    
}
