using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nauka._2021
{
    class Day3
    {

        public static async Task Binary()
        {

            string url = "https://adventofcode.com/2021/day/3/input";

            string[] input = await InputHelperHttp.InputHelper(url);  

            var gammaBinary = "";

            var epsilonBinary = "";


            for (int i = 0; i < input[0].Length; i++)
            {
                var jedynki = 0;

                var zera = 0;
                foreach (var line in input)
                {

                    
                    if (line[i] == '1')
                    {
                        jedynki++;
                    }
                    else
                    {
                        zera++;
                    }

                }
                    if(jedynki > zera)
                    {
                        gammaBinary += '1';
                        epsilonBinary += '0';
                    }
                    else
                    {
                        gammaBinary += '0';
                        epsilonBinary += '1';
                    }






            }

            var gamma = Convert.ToInt32(gammaBinary, 2);
            var epsilon = Convert.ToInt32(epsilonBinary, 2);

            var wynik = gamma * epsilon;
            Console.WriteLine($"MOC:{wynik}, " +
                $"Gamma:{gamma}, " +
                $" Epsilon:{epsilon}, " +
                $" gammaBinarna:{gammaBinary}, " +
                $" epsilonBinarny:{epsilonBinary}");


        }
        
    }

}
