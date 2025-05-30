using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AoC2024
{
    internal class Day2
    {
        public static void Reports()
        {
            int hh = 0;
            var linesInt = new List<int>();
            int gg = 0;
           


            string path = @"C:\Users\Testosterator\Desktop\UE4\AoC2024\inputd2.txt";
            
            
                
                foreach (string line in File.ReadLines(path))
                {                                   
                    foreach(string line2 in line.Split(' '))
                    {
                        linesInt.Add(int.Parse(line2));
                    }
                    bool n = true;
                    for (int i = 0; i < linesInt.Count - 1; i++)
                    {
                        gg = Math.Abs(linesInt[i] - linesInt[i + 1]);
                        if (gg < 1 || gg > 3)
                        {
                            n = false;
                            break; // Nie ma sensu dalej sprawdzać
                        }

                    }
                   
                        
                        if (n)
                        {
                            bool t = (linesInt.Zip(linesInt.Skip(1), (a, b) => a.CompareTo(b) <= 0).All(b => b));
                            bool f = (linesInt.Zip(linesInt.Skip(1), (a, b) => a.CompareTo(b) >= 0).All(b => b));
                            if (t || f)
                            {
                                hh++;
                            }

                        }
                        
                        
                        linesInt.Clear();
                    
                }
                        

                Console.WriteLine(hh);
            }





            
                
            
            
        }


    }

