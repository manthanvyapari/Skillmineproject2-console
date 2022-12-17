using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2
{
    class StringCompair
    {
        static void Main(string[] args)
        {
            string str1 = "test";
            string str2 = "Test";
            char[] ch = { 't', 'e', 's', 't' };

            int a = string.Compare(str1,str2);
            Console.WriteLine(a);

            bool res = str1.Equals(str2);
            Console.WriteLine(res);        //false

            bool r1 = string.IsNullOrEmpty(str1);
            Console.WriteLine(r1);

            string str3 = new string(ch);
            Console.WriteLine(str3);
            bool result = str1.Equals(str3);
            Console.WriteLine(result);


            if (str1 == str3)
            {
                Console.WriteLine("True");
            }
            else                                      //true
            {
                Console.WriteLine("False");    
            }




        }
    }
}
