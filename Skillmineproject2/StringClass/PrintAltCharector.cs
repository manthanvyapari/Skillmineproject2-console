using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.StringClass
{
    class PrintAltCharector
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
             string result = "";

            for(var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result+= str[i];
                }
            }

            Console.WriteLine(result);
        }

    }
}
