using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2
{
    public  class ExtensionMethodclass
    {
        public void M1()
        {
            Console.WriteLine("m1 method");
        }

        public void M2()
        {
            Console.WriteLine("m2 method");
        }

    }   
}




//public static class Extensionclass
//{
//    public static void M3(this ExtensionMethodclass ex1)
//    {                                                                                 //extension method                                                                   
//        Console.WriteLine("m3 method");
//    }
//    public static void M4(this ExtensionMethodclass ex1)
//    {
//        Console.WriteLine("m4 method");
//    }

//}
