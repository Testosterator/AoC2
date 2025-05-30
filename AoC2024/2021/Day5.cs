using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nauka._2021
{
    class Day5
    {
        public async static Task Hydrothermal()
        {
            string url = "https://adventofcode.com/2021/day/5/input";
            string[] input = await InputHelperHttp.InputHelper(url, StringSplitOptions.RemoveEmptyEntries);

            // Rozmiar planszy - zakładamy maksymalnie 1000x1000
            int[,] plansza = new int[1000, 1000];

            int wynik_koncowy = 0;
            int lineNumber = 0;

            foreach (var line in input)
            {
                lineNumber++;

                Match match = Regex.Match(line, @"(\d+),(\d+)\s*->\s*(\d+),(\d+)");
                if (!match.Success)
                {
                    Console.WriteLine($"Błąd parsowania w linii {lineNumber}: '{line}'");
                    continue;
                }

                int x1 = int.Parse(match.Groups[1].Value);
                int y1 = int.Parse(match.Groups[2].Value);
                int x2 = int.Parse(match.Groups[3].Value);
                int y2 = int.Parse(match.Groups[4].Value);

                try
                {
                    Paint(plansza, x1, y1, x2, y2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd w Paint() dla linii {lineNumber}: {x1},{y1} -> {x2},{y2}");
                    Console.WriteLine(ex.Message);
                }
            }

            // Liczymy przecięcia (wartości >= 2)
            foreach (var cell in plansza)
            {
                if (cell >= 2)
                {
                    wynik_koncowy++;
                }
            }

            Console.WriteLine($"Liczba punktów, gdzie nakładają się co najmniej dwie linie: {wynik_koncowy}");
        }

        public static void Paint(int[,] grid, int x1, int y1, int x2, int y2)
        {
            if (x1 == x2) // pionowa linia
            {
                int start = Math.Min(y1, y2);
                int end = Math.Max(y1, y2);
                for (int y = start; y <= end; y++)
                {
                    if (x1 < grid.GetLength(0) && y < grid.GetLength(1))
                        grid[x1, y]++;
                }
            }
            else if (y1 == y2) // pozioma linia
            {
                int start = Math.Min(x1, x2);
                int end = Math.Max(x1, x2);
                for (int x = start; x <= end; x++)
                {
                    if (x < grid.GetLength(0) && y1 < grid.GetLength(1))
                        grid[x, y1]++;
                }
            }
            else
            {
                // Pomijamy skośne linie zgodnie z treścią zadania (część 1)
            }
        }
    }
}
