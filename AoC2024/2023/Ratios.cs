using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Ratios
{
    public static void Gear()
    {
        string path = @"C:\Users\Kamil\Desktop\VS\2023_D3.txt"; // Zmień na swoją ścieżkę
        string[] grid = File.ReadAllLines(path);
        int rows = grid.Length;
        int cols = grid[0].Length;
        int wynik = 0;

        string pattern = @"\d+"; // Znajduje liczby

        for (int y = 0; y < rows; y++)
        {
            MatchCollection matches = Regex.Matches(grid[y], pattern);

            foreach (Match match in matches)
            {
                int liczba = int.Parse(match.Value);
                int startX = match.Index;
                int endX = startX + match.Length - 1;

                // Sprawdzamy otoczenie liczby - jeśli sąsiaduje z symbolem, dodajemy do sumy
                if (HasSymbolNeighbor(grid, startX, endX, y, rows, cols))
                {
                    wynik += liczba;
                }
            }
        }

        Console.WriteLine($"Suma part numbers: {wynik}");
    }

    // Sprawdza, czy liczba ma w pobliżu symbol (nie licząc '.')
    static bool HasSymbolNeighbor(string[] grid, int startX, int endX, int y, int rows, int cols)
    {
        for (int i = startX - 1; i <= endX + 1; i++) // Sprawdzamy lewo, prawo i wokół liczby
        {
            if (i >= 0 && i < cols)
            {
                if (y - 1 >= 0 && IsSymbol(grid[y - 1][i])) return true; // Góra
                if (y + 1 < rows && IsSymbol(grid[y + 1][i])) return true; // Dół
            }
        }

        // Sprawdzamy lewo i prawo
        if (startX - 1 >= 0 && IsSymbol(grid[y][startX - 1])) return true;
        if (endX + 1 < cols && IsSymbol(grid[y][endX + 1])) return true;

        return false;
    }

    // Sprawdza, czy znak to symbol (czyli coś innego niż cyfra i '.')
    static bool IsSymbol(char c)
    {
        return c != '.' && !char.IsDigit(c);
    }
}
