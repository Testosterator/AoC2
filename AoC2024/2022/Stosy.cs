using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nauka._2022
{
    class Stosy
    {
        public static void Przenoszenie()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2022_5.txt";
            var input = File.ReadLines(path);
            int a = 0;
            int b = 0;
            int c = 0;
            List<Stack<char>> listaStosow = new List<Stack<char>>
            {
                new Stack<char>(new char[]{'D','L','V','T','M','H','F'}),
                new Stack<char>(new char[]{'H','Q','G','J','C','T','N','P'}),
                new Stack<char>(new char[]{'R','S','D','M','P','H'}),
                new Stack<char>(new char[]{'L','B','V','F'}),
                new Stack<char>(new char[]{'N','H','G','L','Q'}),
                new Stack<char>(new char[]{'W','B','D','G','R','M','P'}),
                new Stack<char>(new char[]{'G','M','N','R','C','H','L','Q'}),
                new Stack<char>(new char[]{'C','L','W'}),
                new Stack<char>(new char[]{'R','D','L','Q','J','Z','M','T'})
            };


            foreach (var lines in input)
            {
                if(string.IsNullOrWhiteSpace(lines))
                {
                    break;
                }
                else
                {
                    
                    string pattern = @"\d+";
                    var Values = Regex.Matches(lines, pattern);
                    a = int.Parse(Values[0].Value);
                    b = int.Parse(Values[1].Value) - 1;
                    c = int.Parse(Values[2].Value) - 1;
                    
                    PrzeniesBezZmianyKolejnosci(listaStosow[b], listaStosow[c], a);
                   
                    

                }

               




            }
            foreach (var stack in listaStosow)
            {
                Console.WriteLine(string.Join(", ", stack)); 
            }

            string odp = " ";
            for (int i = 0; i < 9; i++)
            {
                 odp += listaStosow[i].Peek().ToString();
            }
            Console.WriteLine(odp);




        static void PrzeniesBezZmianyKolejnosci(Stack<char> zrodlo, Stack<char> cel, int ile)
        {
                List<char> bufor = new List<char>();

                // Pobierz `ile` elementów i ZACHOWAJ KOLEJNOŚĆ
                for (int i = 0; i < ile && zrodlo.Count > 0; i++)
                {
                    bufor.Add(zrodlo.Pop());
                }

                // Dodaj elementy do nowego stosu w TEJ SAMEJ KOLEJNOŚCI
                for (int i = bufor.Count - 1; i >= 0; i--)
                {
                    cel.Push(bufor[i]);
                }
            }
        }
    }

}
