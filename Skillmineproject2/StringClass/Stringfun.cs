using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.StringClass
{
    class Stringfun
    {
        static void Main(string[] args)
        {
            string str1 = "Life is full complecity";
            Console.WriteLine(str1.Length);

            string str2 = "Go with the Flow";
            str1.Concat(str2);
            string str = String.Concat(str1, str2);
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            bool result = str1.StartsWith("Life");
            Console.WriteLine(result);                 //true

            bool res = str1.EndsWith("enjoy");
            Console.WriteLine(res);                    //false

            bool r = str1.Contains("is");
            Console.WriteLine(r);

            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());

            char[] ch = str1.ToCharArray();
            foreach (var item in ch)
            {
                Console.WriteLine(item);

            }

            str1.Trim();


            StringBuilder sb = new StringBuilder("Hellow World");
            Console.WriteLine(sb);
            sb.Append("Wellcome home");

             double price = 45000;
            sb.AppendFormat("price is {0:C}", price);
            Console.WriteLine(sb);
        }
    }
}
