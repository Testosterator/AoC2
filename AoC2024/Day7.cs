using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace AoC2024
{
    internal class Day7
    {
        public static void Bridge()
        {
            string path = @"C:\Users\Testosterator\Desktop\UE4\AoC2024\inputd7.txt";
            var INput = File.ReadAllLines(path);
            string Patern = @"\d+";
             
            List<string> input = [.. INput];




            MatchCollection matches = Regex.Match();

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);



            }






        }













    }
}
