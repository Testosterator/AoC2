using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nauka
{
    class Haunted
    {
        public static void Lands()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2023_D8.txt";
            var grid = File.ReadAllLines(path);
            string instrukcja = grid[0];
            string[] input = grid.Skip(1).ToArray();
            string V1 = " ";
            string V2 = " ";
            string V3 = " ";
            int i = 0;
            

            do
            {
                foreach (var line in input)
                {
                                        

                    Regex regex = new Regex(@"(\w+)\s*=\s*\((\w+),\s*(\w+)\)");
                    Console.WriteLine(line);
                    Match match = regex.Match(line);
                    if (match.Success)
                    {
                        V1 = match.Groups[1].Value;
                        V2 = match.Groups[2].Value;
                        V3 = match.Groups[3].Value;
                    }
                    if (instrukcja[i] == 'L')
                    {
                        V1 = V2;
                    }
                    else
                    {
                        V1 = V3;
                    }

                }
            } while (V1 != "ZZZ");

            
            

        }
    }
}
