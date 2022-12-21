using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.ArrayC
{
    class Movezero
    {  
        public void PushzerotheStart(int[]arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }


                Console.WriteLine(arr[i]);
            }
           

        }
        // public void PushzerotheEnd(int[] arr)
        //{
        //    for(int i = arr.Length-1; i >= 1; i--)
        //    {
        //        for (int j = i - 1; j >=0; j--)
        //        {
        //            if (arr[j] == 0)
        //            {
        //                int temp = arr[i];
        //                arr[i] = arr[j];
        //                arr[j] = temp;
        //            }
        //        }
        //        Console.WriteLine(arr[i]);
        //    }
        //}


        static void Main(string[] args)
        {
            int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };

            Movezero m = new Movezero();
            Console.WriteLine("Zero at start ");
            m.PushzerotheStart(arr);
            Console.WriteLine("Zero at End");
         //   m.PushzerotheEnd(arr);

            
        }
    }
}
