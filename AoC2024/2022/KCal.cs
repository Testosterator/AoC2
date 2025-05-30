using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka
{
    class KCal
    {
        public static void Cal()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2022_1.txt";
            var input = File.ReadLines(path);
            
            
            int H = 0;
            List<int> three = new();

            foreach(var line in input)
            {         

                
                if(!string.IsNullOrWhiteSpace(line))
                {
                   H += int.Parse(line.Trim());                  

                }
                else
                {
                    three.Add(H);
                    H = 0;
                }    
                


                


            }
            int e = 0;
            var sort = three.Where(x => x > 0).OrderBy(x => x);
            var pp = sort.ToList();
            for (int i = pp.Count - 1; i > pp.Count - 4; i--)
            {
                e += pp[i];
                Console.WriteLine(pp[i]);
            }
            Console.WriteLine(e);











        }
    }
}
