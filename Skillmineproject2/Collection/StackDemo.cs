using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Skillmineproject2.Collection
{
    class StackDemo    //Last in frist out
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push("Hello my name is ________");
            stack.Push(30);
            stack.Push(40);

            Console.WriteLine("TOP ELEMENT ON STACK-->" +stack.Peek());


            foreach( var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}
