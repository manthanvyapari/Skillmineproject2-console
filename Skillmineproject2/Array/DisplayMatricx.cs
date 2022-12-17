using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.Array
{
    class DisplayMatricx
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 3]
            {
                {1,2,3 },
                {1,2,3 },
                { 1,2,3},
                { 1,2,3}

            };
            foreach(var item in a)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("==================================");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i,j]+ " ");
                }
                Console.WriteLine();
            }
                      
                

        }
    }
}
