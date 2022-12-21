using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.ArrayC
{
    class PairofElement
    {

        public void  FindPair(int[]num ,int n,int p)
        {
            for(int i = 0; i < n- 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (num[i] + num[j] == p)
                    {
                        Console.WriteLine("pairs are found" + num[i], num[j]);
                    }
                  
                    else
                    {
                        Console.WriteLine("pairs not found");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] num = { 8, 7, 2, 5, 3, 1 };
            int p= 10;

            PairofElement s = new PairofElement();
           







        }

    }
}
