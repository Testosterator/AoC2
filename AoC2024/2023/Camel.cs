using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nauka
{
    class Camel
    {
        public static void Card()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2023_D7.txt";
            string[] grid = File.ReadAllLines(path);

            List<(string Hand, int Bet)> hands = new List<(string, int)>();

            // Wartości kart w kolejności siły
            Dictionary<char, int> Values = new Dictionary<char, int>
            {
                { 'A', 14 }, { 'K', 13 }, { 'Q', 12 }, { 'J', 11 }, { 'T', 10 },
                { '9', 9 }, { '8', 8 }, { '7', 7 }, { '6', 6 }, { '5', 5 },
                { '4', 4 }, { '3', 3 }, { '2', 2 }
            };

            // Wczytanie danych
            foreach (var line in grid)
            {
                string[] parts = line.Split(' ');
                hands.Add((parts[0], int.Parse(parts[1])));
            }

            // Sortowanie rąk według siły (najpierw typ ręki, potem wartości kart)
            hands.Sort(CompareHands);

            // Obliczanie wyniku: rank * bet
            int totalScore = 0;
            for (int rank = 1; rank <= hands.Count; rank++)
            {
                totalScore += rank * hands[rank - 1].Bet;
            }

            Console.WriteLine($"Total Score: {totalScore}");
        }

        public static int CompareHands((string Hand, int Bet) hand1, (string Hand, int Bet) hand2)
        {
            int rank1 = GetHandRank(hand1.Hand);
            int rank2 = GetHandRank(hand2.Hand);

            // Najpierw porównujemy typ układu
            if (rank1 != rank2)
                return rank1.CompareTo(rank2);

            // Jeśli układy są równe, porównujemy wartości kart od lewej do prawej
            for (int i = 0; i < hand1.Hand.Length; i++)
            {
                int val1 = GetCardValue(hand1.Hand[i]);
                int val2 = GetCardValue(hand2.Hand[i]);

                if (val1 != val2)
                    return val1.CompareTo(val2);
            }

            return 0; // Ręce są identyczne
        }

        public static int GetHandRank(string hand)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            // Liczymy wystąpienia kart w ręce
            foreach (char card in hand)
            {
                if (count.ContainsKey(card))
                    count[card]++;
                else
                    count[card] = 1;
            }

            // Pobieramy wartości powtórzeń i sortujemy malejąco
            var groups = count.Values.OrderByDescending(v => v).ToList();

            if (groups.SequenceEqual(new List<int> { 5 })) return 7; // Pięć kart tego samego rodzaju
            if (groups.SequenceEqual(new List<int> { 4, 1 })) return 6; // Kareta
            if (groups.SequenceEqual(new List<int> { 3, 2 })) return 5; // Full House
            if (groups.SequenceEqual(new List<int> { 3, 1, 1 })) return 4; // Trójka
            if (groups.SequenceEqual(new List<int> { 2, 2, 1 })) return 3; // Dwie pary
            if (groups.SequenceEqual(new List<int> { 2, 1, 1, 1 })) return 2; // Jedna para
            return 1; // Wysoka karta
        }

        public static int GetCardValue(char card)
        {
            Dictionary<char, int> Values = new Dictionary<char, int>
            {
                { 'A', 14 }, { 'K', 13 }, { 'Q', 12 }, { 'J', 11 }, { 'T', 10 },
                { '9', 9 }, { '8', 8 }, { '7', 7 }, { '6', 6 }, { '5', 5 },
                { '4', 4 }, { '3', 3 }, { '2', 2 }
            };

            return Values[card];
        }
    }
}
