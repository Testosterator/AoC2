using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace nauka._2021
{
    public class Day1
    {
        public static async Task Pon()
        {
            string url = "https://adventofcode.com/2021/day/1/input";

            int a = 0;

            string[] input = await InputHelperHttp.InputHelper(url);

            
                    int poprzedni = int.Parse(input[0]);
                    
                        for (int i = 1; i < input.Length; i++)
                        {
                            int bierzacy = int.Parse(input[i]);
                            if (poprzedni < bierzacy)
                            {
                                a++;
                            }
                            poprzedni = bierzacy;

                        }
                        
                       


                        
                        
                        
                        

                        
                    

                Console.WriteLine($"Wynik: {a}");
                }

            
         
    }
}

