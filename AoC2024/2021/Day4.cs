using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nauka._2021
{
    class Day4
    {
        public static async Task Giant_Squid()
        {
            string url = "https://adventofcode.com/2021/day/4/input";

            string[] input = await InputHelperHttp.InputHelper(url, StringSplitOptions.None);

            List<string[,]> Grid5x5 = new();
            List<string> WiningNumbers = new();

            WiningNumbers.Add(input[0]);
            WiningNumbers.Add(input[1]);

            int index = 2;
            while (index < input.Length)
            {
                // Pomijamy pustą linię między planszami, jeśli jest
                if (string.IsNullOrWhiteSpace(input[index]))
                {
                    index++;
                    continue;
                }

                // Tworzymy nową planszę 5x5
                string[,] grid = new string[5, 5];

                // Wczytujemy 5 wierszy
                for (int row = 0; row < 5; row++)
                {
                    var numbers = input[index].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    for (int col = 0; col < 5; col++)
                    {
                        grid[row, col] = numbers[col];
                    }
                    index++;
                }

                Grid5x5.Add(grid); // Dodajemy planszę do listy

            }

            Console.WriteLine("~~DUPA~~\n");

            foreach (var line in Grid5x5)
            {

                //+1.Piersze linie wczytac do Listy 

                //+2. Jakos posegregowac plansze 5x5

                //3. Przejsc przez wszystkie 5x5 sprawdzajac kazda cyfre z listy i liczac kroki do osiagniecia celu 
                //   wybrac ta ktora potrzebuje najmniej krokow do wypelnienia poziomu lub pionu

                //4. Dodac warunek sprawdzajacy wygrana
                //4a. Szukamy pierszej wygrywajacej planszy

                //5. Zliczyc nie wybrane cyfry i pomnozyc je przez aktualna cyfre(ta ktora daje wygrana)
                Console.WriteLine(line);

            }
            Console.WriteLine("~~DUPA~~\n");

        }

        
    }
}
