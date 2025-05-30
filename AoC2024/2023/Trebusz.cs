using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka
{
    class  Trebusz
    {
        public static void Find()
        {
            string path = @"C:\\Users\\Kamil\\Desktop\\VS\\2023_D1.txt";
            var Input = File.ReadLines(path);

            char[] digits = { '0','1','2','3','4','5','6','7','8','9'};
            char first = ' ';
            char last = ' ';
            int x = 0;
            


            foreach (var line in Input)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    foreach(var ch in digits)
                    {
                         
                            if(line[i].Equals(ch) && first == ' ')
                            {
                             first = line[i];
                             last = line[i];

                            }
                            
                        if (line[i].Equals(ch))
                        {                            
                            last = line[i];

                        }
                    }
                }
                Console.WriteLine($"Linia: {line}, Pierszy= {first}, Ostatni= {last}");
                x += int.Parse(first.ToString() + last.ToString());
                first = ' ';
            
            
            
            
            
            
            }
            Console.WriteLine($"Suma ={x}");






        }
    }
}
