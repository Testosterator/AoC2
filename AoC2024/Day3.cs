using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace AoC2024
{
    internal class Day3
    {
        public static void Mull() 
        {
            int z = 0;
            string path = @"C:\Users\Testosterator\Desktop\UE4\AoC2024\inputd3.txt";
            string[] input = File.ReadAllLines(path);
            string h = string.Join(" ", input);
            string pattern = @"mul\((\d+),(\d+)\)";
            
                foreach (Match match in Regex.Matches(h, pattern))
                {
                int x = int.Parse(match.Groups[1].Value); 
                int y = int.Parse(match.Groups[2].Value);
                z += x * y;


            }
            Console.WriteLine(z);



        }
    }
}
