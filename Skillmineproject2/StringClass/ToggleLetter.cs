using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.StringClass
{
    class ToggleLetter
    {
        static void Main(string[] args)
        {
            string str1= "HeLlo";
            string str2 = "hElLo";

            string str3 = "Hello to all";
            string str4 = "Welcome to all";


            int a = string.Compare(str1, str2);
            Console.WriteLine(a);


            bool result =str3.Contains("all");
            bool r = str4.Contains("to");

            Console.WriteLine(result);
            Console.WriteLine(r);

        }
    }
}
