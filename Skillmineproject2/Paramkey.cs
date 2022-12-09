using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2
{
    class Paramkey
    {
        static void AcceptNames(params string[] names)
        {
            Console.WriteLine("Values to print " + names.Length);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        //static void Main(string[] args)
        //{
        //    AcceptNames("Amol", "kishor");
        //    AcceptNames("Amol", "Kishor", "Ajay");
        //    AcceptNames("Amol", "Kishor", "Suraj", "Rohan");


        //}
    }
}
