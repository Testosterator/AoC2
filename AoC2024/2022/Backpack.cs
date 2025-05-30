using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka._2022
{
    class Backpack
    {
        public static void Sort()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2022_3.txt";
            var input = File.ReadLines(path);
            List<char> Identyczne = new();

            foreach(var line in input)
            {
                var pierwsza_polowa = line.Substring(0, (line.Length / 2));
                var druga_polowa = line.Substring(line.Length / 2);
                //Console.WriteLine($"{pierwsza_polowa}  \n  {druga_polowa}");

                for (int i = 0; i < pierwsza_polowa.Length; i++)
                {
                    for (int j = 0; j < druga_polowa.Length; j++)
                    {
                        if (pierwsza_polowa[i] == druga_polowa[j])
                        {
                            Identyczne.Add(pierwsza_polowa[i]);
                            goto KONIEC;
                        }


                    }

                }
            KONIEC:;
            }
            int ppp = 0;
            foreach(var pp in Identyczne)
            {
                Console.WriteLine($"{pp}: {GetPriority(pp)}");                
                ppp += GetPriority(pp);
            }
            Console.WriteLine(ppp);

            int GetPriority(char c)
            {
                if (char.IsLower(c)) return c - 'a' + 1;   // 'a' = 1, 'b' = 2, ..., 'z' = 26
                if (char.IsUpper(c)) return c - 'A' + 27;  // 'A' = 27, 'B' = 28, ..., 'Z' = 52
                return 0; // Jeśli znak nie jest literą
            }
            //Teraz jakos sprawdzic kazdy zank przez kazdy znak zobaczyc cyz sa takie same, dodaj je do listy ,
            //pozniej liste zamienic na inty wg wzoru dodac do siebie i mamy wynik ! :)  




        }
    }
}
