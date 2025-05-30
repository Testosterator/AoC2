using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka
{
    class Zdrapki
    {
        public static void Suma()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2023_D4.txt";
            var Input = File.ReadLines(path);
            double Suma = 0;
            foreach(var line in Input)
            {
                string[] podział = line.Split('|');
                string[] wygrywajace = podział[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                HashSet<string> moje = new HashSet<string>(podział[1].Split(' ', StringSplitOptions.RemoveEmptyEntries));
                
                int s = wygrywajace.Count(moje.Contains); // Unikamy podwójnego liczenia

                if (s > 0)
                {
                    Suma += Math.Pow(2.0, s - 1);
                }
                






            }
            Console.WriteLine(Suma);
        }
    }
}
