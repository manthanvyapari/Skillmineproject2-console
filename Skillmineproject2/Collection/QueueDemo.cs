using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.Collection
{
    class QueueDemo           //FRIST IN FRIST OUT
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            queue.Dequeue();  //remove frist elememt

            Console.WriteLine("PEAK ELEMENT IN QUEUE IS---->"+queue.Peek());
               

            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
        }
       

       

            
    }
}
