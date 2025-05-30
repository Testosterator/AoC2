using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AoC2024
{
    internal class Day4
    {
        public static void Xmax()
        {
            string path = @"C:\Users\Testosterator\Desktop\UE4\AoC2024\inputd4.txt";
            var Text = File.ReadAllText(path);
            Text.ToCharArray();

            foreach (char c in Text) 
            { 
                if (c != 'X' || c != 'M' || c != 'A' || c != 'S')
                {
                    Text.Replace(c, '.');
                }
            
            }
            Console.WriteLine(Text);



        }



    }
}
