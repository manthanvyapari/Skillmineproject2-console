using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.EventsAndDeligets
{
   
    class EventDeligatesBind
    {

       // declaration of delegate
        public delegate int Mydel1(int n1, int n2);

        public class Test
        {

            public int Add(int a, int b)
            {
                return a + b; 
            }
            public int Multiply(int a, int b)
            {
                return a * b;
            }
            public int Sub(int a, int b)
            {
                return a - b;
            }

        }
        public class Helper
        {
            public event Mydel1 Addition;
            public event Mydel1 Subtraction;
            public event Mydel1 Multiplication;

            public int M1(int a, int b)
            {
                return Addition(a, b);  // raise an event
            }
            public int M2(int a, int b)
            {
                return Subtraction(a, b);
            }
            public int M3(int a, int b)
            {
                return Multiplication(a, b);
            }
        }
        
        
            static void Main(string[] args)
            {
                Test test = new Test();
                Helper h = new Helper();
                h.Addition += new Mydel1(test.Add);
                h.Subtraction += new Mydel1(test.Sub);
                h.Multiplication += new Mydel1(test.Multiply);

                Console.WriteLine("Enter two numbers");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("Select option");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        int sum = h.M1(a, b);
                        Console.WriteLine(sum);
                        break;
                    case 2:
                        int m = h.M2(a, b);
                        Console.WriteLine(m);
                        break;
                    case 3:
                        int sub = h.M3(a, b);
                        Console.WriteLine(sub);
                        break;
                    default:
                        Console.WriteLine("No output");
                        break;
                }
            }


        
    }

}

