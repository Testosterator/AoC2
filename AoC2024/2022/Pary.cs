using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka._2022
{
    class Pary
    {
        public static void Elfy()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2022_4.txt";
            var input = File.ReadLines(path);
            int Pary = 0;
            int spol = 0;

            foreach (var line in input)
            {
                List<int> E2 = new();
                List<int> E1 = new();
                var Elfy = line.Split(",");
                var Elf1 = Elfy[0].Split("-");
                var Elf2 = Elfy[1].Split("-");

                //Elf 1 
                for (int i = int.Parse(Elf1[0]); i <= int.Parse(Elf1[1]); i++)
                {
                    E1.Add(i);
                }
                //Elf 2
                for (int i = int.Parse(Elf2[0]); i <= int.Parse(Elf2[1]); i++)
                {
                    E2.Add(i);
                }
                

                if(E1.All(E2.Contains))
                {
                    Pary++;
                }
                else if (E2.All(E1.Contains))
                {
                    Pary++;
                }
                if(E1.Intersect(E2).Any() || E2.Intersect(E1).Any())
                {
                    spol++;
                }


            }
            Console.WriteLine($"Ilosc par : { Pary}");
            Console.WriteLine($"Ilosc wspolna : {spol}");




        }
    }
}
