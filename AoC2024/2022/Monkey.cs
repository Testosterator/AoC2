using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace nauka._2022
{
    class Monkey
    {
        public static long liczbadzielniko = 1;
        public static void Stress()
        {
            //Dodanie Malp
            List<Apes> listMalp = new List<Apes>();
            listMalp.Add(new Apes(0, new Queue<long>(new long[] { 50, 70, 89, 75, 66, 66 }), 5, 2, 2, 1));
            listMalp.Add(new Apes(1, new Queue<long>(new long[] { 85 }), 1, 7, 3, 6));
            listMalp.Add(new Apes(2, new Queue<long>(new long[] { 66, 51, 71, 76, 58, 55, 58, 60 }), 1, 13, 1, 3));
            listMalp.Add(new Apes(3, new Queue<long>(new long[] { 79, 52, 55, 51 }), 6, 3, 6, 4));
            listMalp.Add(new Apes(4, new Queue<long>(new long[] { 69, 92 }), 17, 19, 7, 5));
            listMalp.Add(new Apes(5, new Queue<long>(new long[] { 71, 76, 73, 98, 67, 79, 99 }), 8, 5, 0, 2));
            listMalp.Add(new Apes(6, new Queue<long>(new long[] { 82, 76, 69, 69, 57 }), 7, 11, 7, 4));
            listMalp.Add(new Apes(7, new Queue<long>(new long[] { 65, 79, 86 }), 5, 17, 5, 0));
            
            foreach (var p in listMalp)
            {
                checked
                {

                liczbadzielniko = liczbadzielniko * p.Dzielnik;
                }
            }

            
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < listMalp.Count; j++)
                {
                    while (listMalp[j].Itemki.Count > 0)
                    {
                        listMalp[j].Przekazanie(listMalp);
                    }

                }
            }

            foreach (var malpa in listMalp)
            {
                Console.WriteLine($"Małpa {malpa.NrMalpy}: {string.Join(", ", malpa.throws)}");

            }

            // Posortuj małpy według liczby inspekcji i wybierz 2 najwyższe wartości
            var topTwo = listMalp.OrderByDescending(m => m.throws).Take(2).ToList();

            long wynik = topTwo[0].throws * topTwo[1].throws;
            Console.WriteLine($"{topTwo[0].throws} razy {topTwo[1].throws}");
            Console.WriteLine($"Poziom małpiego biznesu: {wynik}");





        }
        class Apes
        {
            public long NrMalpy { get; }
            public Queue<long> Itemki { get; }
            public long Wspolczynnik { get; }
            public int Dzielnik { get; }
            public int Prawda { get; }
            public int Falsz { get; }

            public long throws =0;
                
            public long Wystapienia { get; }

            public Apes(int nrMalpy, Queue<long> itemki, int wspolczynnik, int dzielnik, int prawda, int falsz)
            {
                NrMalpy = nrMalpy;
                Itemki = itemki;
                Wspolczynnik = wspolczynnik;
                Dzielnik = dzielnik;
                Prawda = prawda;
                Falsz = falsz;
                
                
            }

                public void Przekazanie(List<Apes> malpy)
                {
                    if (Itemki.Count == 0) return;  // Jeśli małpa nie ma przedmiotów, nie robi nic

                    long item = Itemki.Dequeue(); // Pobranie pierwszego przedmiotu z kolejki

                    long do_przekazania = 0;

                    

                    // Obliczanie nowej wartości
                    if (NrMalpy == 0 || NrMalpy == 4)
                    {
                        do_przekazania = item * Wspolczynnik;
                    }
                else if (NrMalpy == 1)
                {
                    do_przekazania = item * item;
                }
                else
                {
                    do_przekazania = item + Wspolczynnik;
                }
                 
                
                    
                
                do_przekazania = do_przekazania % liczbadzielniko;


                // Sprawdzenie podzielności i wybór docelowej małpy
                int docelowaMalpa = (do_przekazania % Dzielnik == 0) ? Prawda : Falsz;
                // Przekazanie wartości do odpowiedniej małpy
                malpy[docelowaMalpa].Itemki.Enqueue((int)do_przekazania);
                throws++;
            }

        }
    }
 }

