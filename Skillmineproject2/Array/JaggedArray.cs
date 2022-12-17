using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.Array
{
    class JaggedArray

    { 
        static void Main(string[] args)
        {
            int[][] jaggedarray = new int[4][];
            jaggedarray[0] = new int[] { 1, 5, 7, 9 };
            jaggedarray[1] = new int[] { 100,200,300 };
            jaggedarray[2] = new int[] { 10,20  };

            for(int i = 0; i <jaggedarray.Length; i++)
            {
                for (int j = 0; j < jaggedarray[i].Length; j++)
                {
                   
                    Console.Write(jaggedarray[i][j] + " ");

                }
                Console.WriteLine();
            }
          
        }
    }

}
