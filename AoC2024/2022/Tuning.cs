using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka._2022
{
    class Tuning
    {
        public static void Trouble()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2022_6.txt";
            var input = File.ReadAllText(path);
            List<char> znaki = new();
            int k = 0;

            foreach (var litera in input)
            {
                znaki.Add(litera);

                if (znaki.Count > 14)
                {
                    znaki.RemoveAt(0); 
                }

                
                if (znaki.Count == 14 && znaki.Distinct().Count() == 14)
                {
                    Console.WriteLine(k + 1); 
                    break; 
                }
                k++;
            }
        }
    }
}
