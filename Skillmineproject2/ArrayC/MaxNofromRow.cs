using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.ArrayC
{
    class MaxNofromRow
    {
        public void FindRowMax(int[,] a)
        {
            for(int i = 0; i <= a.GetLength(1); i++)
            {
                int max = a[0, i];
                for(int j = 0; j <= a.GetLength(0); j++)
                {
                    if (a[i,j] > max)
                    {
                        max = a[i,j];
                    }
                }

                Console.Write("Max--->"+max);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] arr =
            {
                {1,2,3,4 },
                { 5,6,7,8},
                {9,10,11,12 },

            };



            MaxNofromRow m = new MaxNofromRow();
            m.FindRowMax(arr);


        }
    }
}
