using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nauka._2021
{
    class Day2
    {
        public static async Task Dive()
        {

            string url = "https://adventofcode.com/2021/day/2/input";

            string[] input = await InputHelperHttp.InputHelper(url);

            int horizontal = 0;
            int depth = 0;

            string pattern = @"^(forward|down|up)\s+(\d+)$";
            foreach (var line in input)
            {
                Match match = Regex.Match(line, pattern);

                if (match.Success)
                {
                    string direction = match.Groups[1].Value;
                    int value = int.Parse(match.Groups[2].Value);

                    switch (direction)
                    {
                        case "forward":
                            horizontal += value;
                            break;
                        case "down":
                            depth += value;
                            break;
                        case "up":
                            depth -= value;
                            break;
                    }
                }
            }

            int wynik = horizontal * depth;
            Console.WriteLine($"Wynik: {wynik}");


        }






    }
}
