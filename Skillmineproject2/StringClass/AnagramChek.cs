using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.StringClass
{
    class AnagramChek
    {
        static void Main(string[] args)
        {
            string str1 = "SILENT";
            string str2 = "LISTEN";
            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string s1 = new string(ch2);
            string s2 = new string(ch2);
             
            if (s1 == s2)
            {
                Console.WriteLine("String are Anagrams");

            }
            else
            {
                Console.WriteLine("String are not Anagram");
            }
        }
    }
}
