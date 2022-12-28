using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.EventsAndDeligets
{
    public delegate int mydeligate1(int a, int b);
    public delegate string mydeligate2(string name);
   public class Ddemo
    {
        public int M1(int a,int b)
        {
            return a + b;
        }
        public int M3(int a,int b)
        {
            return a - b;
        }
        public int M4(int a,int b)
        {
            return a * b;
        }

        public string M2(string name)
        {
            return name.ToUpper();
        }


        static void Main(string[] args)
        {
            Ddemo d = new Ddemo();

            mydeligate1 d1 = new mydeligate1(d.M1);
            d1 += new mydeligate1(d.M3);
            d1 += new mydeligate1(d.M4);

            Delegate[] list = d1.GetInvocationList();
            foreach(Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(67, 37));
            }
            

            
           mydeligate2 d2 = new mydeligate2(d.M2);

            //int sum = d1.Invoke(50, 50);
            //Console.WriteLine(sum);

           string name = d2.Invoke("ARGENTINA IS NEW WORLD CHAMPION");
            Console.WriteLine(name);


        }
    }
}
