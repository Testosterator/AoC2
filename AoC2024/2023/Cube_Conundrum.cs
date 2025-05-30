using System;
using System.IO;
using System.Text.RegularExpressions;

namespace nauka
{
    class Cube_Conundrum
    {
        public static void Cube()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2023_D2.txt";
            var Input = File.ReadLines(path);

            int Red = 12, Green = 13, Blue = 14;
            int possible_IDs = 0;

            foreach (var line in Input)
            {
                // Znajdujemy ID gry
                Match idMatch = Regex.Match(line, @"Game (\d+)");
                if (!idMatch.Success) continue; // Jeśli nie ma ID, pomijamy linię
                int gameID = int.Parse(idMatch.Groups[1].Value);

                // Podział na sekcje oddzielone `;`
                string[] sekcje = line.Split(';');
                bool isValid = true; // Zakładamy, że cała gra jest dobra

                foreach (var sekcja in sekcje)
                {
                    // Reset wartości dla każdej sekcji
                    int czerwony = 0, zielony = 0, niebieski = 0;

                    // Pobieramy liczby dla każdego koloru w danej sekcji
                    MatchCollection matches = Regex.Matches(sekcja, @"(\d+)\s+(red|green|blue)");

                    foreach (Match match in matches)
                    {
                        int liczba = int.Parse(match.Groups[1].Value);
                        string kolor = match.Groups[2].Value;

                        if (kolor == "red") czerwony = liczba;
                        else if (kolor == "green") zielony = liczba;
                        else if (kolor == "blue") niebieski = liczba;
                    }

                    // Jeśli którakolwiek sekcja przekroczy limit, cała gra jest odrzucana
                    if (czerwony > Red || zielony > Green || niebieski > Blue)
                    {
                        isValid = false;
                        break; // Nie ma sensu sprawdzać dalej, gra nie spełnia warunków
                    }
                }

                // Jeśli żadna sekcja nie przekroczyła limitu, dodajemy ID gry
                if (isValid)
                {
                    possible_IDs += gameID;
                }
            }

            Console.WriteLine($"Suma Id = {possible_IDs}");
        }
    }
}
