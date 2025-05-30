using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AoC2024
{
    internal class Day1
    {
        public static void Distance()
        {
            List<string> list = new List<string>();
            List<string> x = new List<string>();
            List<string> y = new List<string>();
            List<int> xx = new List<int>();
            List<int> yy = new List<int>();
            List<int> zz = new List<int>();
            string path = @"C:\Users\Testosterator\Desktop\UE4\AoC2024\input.txt";         

            // Open the file to read from.
            string readText = File.ReadAllText(path);            
            char[] readTextArray = readText.ToCharArray().Where(x => !Char.IsWhiteSpace(x)).ToArray();
            string fullText = string.Join("", readTextArray);


            for (int i = 0; i < fullText.Length; i+=5)
            {
                
                if (i % 2 == 0)
                {
                    x.Add(fullText.Substring(i , 5));
                    

                }
                else 
                { 
                    y.Add(fullText.Substring(i, 5));
                   
                }
                
            }


            for (int i = 0; i < x.Count; i++)
            {
                xx.Add(int.Parse(x[i]));
                yy.Add(int.Parse(y[i]));
            }

            xx.Sort();
            yy.Sort();

            for (int i = 0; i < yy.Count; i++)
            {
                zz.Add(Math.Abs(xx[i] - yy[i]));
            }
            
            int Wynik = Math.Abs(zz.Sum());

            Console.WriteLine(Wynik);

        }













    }
}
