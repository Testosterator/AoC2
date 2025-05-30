using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka._2022
{
    class Tree
    {
        public static void House()
        {

            string path = @"C:\Users\Kamil\Desktop\VS\2022_8.txt";
            var input = File.ReadAllLines(path);
            int wynik = 0;
            int wysokosc = input.Length;
            int szerokosc = input[0].Length;
            int[,] drzewa = new int[wysokosc, szerokosc];
            

            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    drzewa[i, j] = input[i][j] - '0';
                    
                }
            }

            for (int y = 0; y < wysokosc; y++)
            {
                for (int x = 0; x < szerokosc; x++)
                {
                    Console.Write(drzewa[y, x]);
                    if (Check_Tree(drzewa, y, x))
                    {
                        wynik++;
                    }
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine(wynik);


            

            bool Check_Tree(int[,]drzewa, int x, int y)
            {
                int[,] kierunki = { { 0, -1 }, { 0, 1 }, { -1, 0 }, { 1, 0 } };

                foreach (var kierunek in Enumerable.Range(0, 4))
                {
                    if (CzyWidoczne(drzewa, x, y, kierunki[kierunek, 0], kierunki[kierunek, 1]))
                    {
                        return true; // Jeśli drzewo jest widoczne w JAKIMKOLWIEK kierunku → widoczne
                        
                    }
                }

                return false; // Jeśli we wszystkich kierunkach jest zasłonięte → niewidoczne
            }
        

        bool CzyWidoczne(int[,] drzewa, int x, int y, int dx, int dy)
        {
            int wysokosc = drzewa[y, x]; // Wysokość aktualnego drzewa
            int maxY = drzewa.GetLength(0); // Ilość wierszy
            int maxX = drzewa.GetLength(1); // Ilość kolumn
             //Odleglosc do ronego drzewa wlacznie.

            x += dx; // Przesunięcie w kierunku X
            y += dy; // Przesunięcie w kierunku Y

            //XXpetlaXX
            while (x >= 0 && x < maxX && y >= 0 && y < maxY) // Sprawdzamy, czy nadal jesteśmy w tablicy
            {
                    
                    if (drzewa[y, x] >= wysokosc) // Jeśli znajdziemy wyższe drzewo – koniec, nie widoczne!
                {
                    return false;
                }

                
                x += dx; // Przesuwamy się dalej w tym kierunku
                y += dy;
            }

            return true; // Jeśli doszliśmy do krawędzi i nie było wyższego drzewa → widoczne!
        }


            //powinienem  w jakis sposob liczyc wszystkie wywolania XXpetlaXX 








    }

}
}

