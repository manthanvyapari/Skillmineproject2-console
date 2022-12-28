using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace Skillmineproject2.MultithredingC
{
    class Demo
    {
        public void M1()
        {
            lock (this)
           {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                   // Thread.Sleep(2000);
                }
            }
                
          
        }
        public void M2()
        {
            for (int i = -10; i <= -5; i++)
            {
                Console.WriteLine(i);
              //Thread.Sleep(2000);
            }
        }
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Thread t1 = new Thread(new ThreadStart(d.M1));
            Thread t2 = new Thread(new ThreadStart(d.M2));
            Thread t3 = new Thread(new ThreadStart(d.M1));

            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
      

           // t2.Priority = ThreadPriority.Highest;
           // t1.Priority = ThreadPriority.BelowNormal;
             
        }
    }
}
