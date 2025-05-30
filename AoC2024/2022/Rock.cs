using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nauka
{
    class Rock
    {
        public static void Scisors()
        {
            string path = @"C:\Users\Kamil\Desktop\VS\2022_2.txt";
            var input = File.ReadLines(path);
            int wynik = 0;

            foreach(var line in input)
            {
                int przecinik = 0;
                    int ja = 0;
                var simsamsum = line.Split(" ");
                //Przeciwnik 1;
                if (simsamsum[0] == "A")
                {
                    przecinik = 1;
                }
                //Przeciwnik 2;
                if (simsamsum[0] == "B")
                {
                    przecinik = 2;
                }
                //Przeciwnik 3;
                if (simsamsum[0] == "C")
                {
                    przecinik = 3;
                }
                //Ja 1
                if (simsamsum[1] == "X")
                {
                    ja = 0;
                    wynik += ja;
                }
                //Ja 2
                if (simsamsum[1] == "Y")
                {
                    ja = 3;
                    wynik += ja;
                }
                //Ja 3
                if (simsamsum[1] == "Z")
                {
                    ja = 6;
                    wynik += ja;
                }

                if (ja == 6)
                {
                    if (przecinik == 1) wynik += 2;
                    if (przecinik == 2) wynik += 3;
                    if (przecinik == 3) wynik += 1;
                }


                //Remis
                else if (ja == 3)
                        {
                            wynik += przecinik;
                        }
                        //Przegrana
                        else if (ja == 0)
                        {
                            if (przecinik == 1) wynik += 3;
                            if (przecinik == 2) wynik += 1;
                            if (przecinik == 3) wynik += 2;
                        }

                





            }
            Console.WriteLine(wynik);









        }
    }
}
