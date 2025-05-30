using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka._2021
{
    class Day6
    {
        public async static Task Fish_Flight()
        {
            string url = "https://adventofcode.com/2021/day/6/input";
            string[] input = await InputHelperHttp.InputHelper(url, StringSplitOptions.RemoveEmptyEntries);

            // Rozdziel liczby po przecinkach i zamień na int
            List<int> light_fish = input[0].Split(',').Select(int.Parse).ToList();

            for (int day = 1; day <= 80; day++)
            {
                int fishToAdd = 0;

                for (int i = 0; i < light_fish.Count; i++)
                {
                    if (light_fish[i] == 0)
                    {
                        light_fish[i] = 6;
                        fishToAdd++;
                    }
                    else
                    {
                        light_fish[i]--;
                    }
                }

                // Dodaj nowe ryby z wartością 8
                for (int i = 0; i < fishToAdd; i++)
                {
                    light_fish.Add(8);
                }

                // Debug: pokaż liczbę ryb po danym dniu
                Console.WriteLine($"Day {day}: {light_fish.Count} fish");
            }

            Console.WriteLine($"\nTotal fish after 80 days: {light_fish.Count}");
        }
    }
}
