using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("работа с git");

            {
                Console.WriteLine("Задание 1:\n");
                int r, n, m, t;
                for (r = 10; r <= 100; r = r + 5)
                {
                    Console.WriteLine(r + " ");
                    Console.WriteLine("\nЗадание №2:\n");
                    n = 0;
                    char smv = 'А';
                    while (n <= 5)
                    {
                        n += 1;
                        Console.Write(smv + " ");
                        smv++;
                        Console.WriteLine("\n\nЗадание 3:\n");
                        n = 6;
                        m = 7;
                        for (n = 0; n <= 6; n++)
                        {
                            for (m = 0; m <= 7; m++)
                            {
                                Console.Write("#");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\nЗадание 4:\n");
                        for (r = 0; r <= 100; r++)
                        {
                            if (r == 0) continue;
                            if ((r % 6) != 0) continue;
                            Console.WriteLine(r + " ");

                        }
                        Console.WriteLine("\nЗадание 5:\n");
                        r = 3;
                        t = 50;
                        for (r = 3, t = 50; t - r > 27; r++, t--)
                        {
                            Console.WriteLine("r и t равны:" + r + "и" + t);
                        }


                    }















                }
            }





        }


    }
}
