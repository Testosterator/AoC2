using System;
using System.IO;
using System.Text.RegularExpressions;

namespace nauka._2022
{
    class Signal
    {
        public static void Strong()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2022_10.txt";
            var input = File.ReadAllLines(path);
            int cykl = 1;
            int force = 1;  // Rejestr X (force) zaczyna od 1
            int suma_force = 0;

            foreach (var line in input)
            {
                string pattern = @"-?\d+";
                Match match = Regex.Match(line, pattern);
                int wartosc = match.Success ? int.Parse(match.Value) : 0;

                // Obsługa "noop" (1 cykl)
                if (line == "noop")
                {
                    if (cykl == 20 || (cykl - 20) % 40 == 0) // Sprawdzenie przed zmianą cyklu
                    {
                        suma_force += cykl * force;
                    }
                    cykl++;  // Przesuwamy cykl na kolejny
                }
                // Obsługa "addx" (2 cykle)
                else if (line.StartsWith("addx"))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (cykl == 20 || (cykl - 20) % 40 == 0) // Sprawdzenie przed zmianą cyklu
                        {
                            suma_force += cykl * force;
                        }
                        cykl++;  // Zwiększamy cykl
                    }
                    force += wartosc; // Dopiero po 2 cyklach zmieniamy wartość X
                }
            }



            Console.WriteLine($"Suma siły sygnału: {suma_force}");
        }
    }
}
