using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nauka
{
    class OASIS
    {
        public static void Oasis()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2023_D9.txt";
            var grid = File.ReadAllLines(path);
            int wynik = 0;
            foreach (var line in grid)
            {
                wynik += Rekurencja(line);

            }
            Console.WriteLine($"Predykcja: {wynik}");
        }

        public static int Rekurencja(string line)
        {
            // Strin na inta
            List<int> liczby = line.Split(' ').Select(int.Parse).ToList();

            // Maja byc same 0 
            if (liczby.All(x => x == 0))
            {
                return 0;
            }

            // Tworzymy nową listę różnic
            List<int> roznice = new();
            for (int i = 0; i < liczby.Count - 1; i++)
            {
                roznice.Add(liczby[i + 1] - liczby[i]);
            }

            // Rekurencyjnie wywołujemy funkcję dla różnic
            int lastDifference = Rekurencja(string.Join(" ", roznice));

            // Obliczamy kolejną wartość i zwracamy wynik
            return liczby.Last() + lastDifference;
        }
    }
}
