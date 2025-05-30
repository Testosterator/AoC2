using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka._2022
{
    class Bubble
    {
        public static void Sorted()
        {

            int[] Array = { 5, 2, 4, 3, 1 };
            int temp;
            foreach (var pp in Array)
            {
                Console.WriteLine(pp);
            }

            for (int j = 0; j < Array.Length; j++)
            {
                for (int i = 0; i < Array.Length -1; i++)
                {

                    if (Array[i] > Array[i + 1])
                    {
                        temp = Array[i + 1];
                        Array[i + 1] = Array[i];
                        Array[i] = temp;
                    }




                }
            }
            foreach(var pp in Array)
            {
                Console.WriteLine(pp);
            }


        }
    }
}
