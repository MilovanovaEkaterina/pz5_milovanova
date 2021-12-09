using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_17
{
    class Program
    {
        static double metod(double[] massiv, double n) //сделала метод с двумя переменными
        {
            for (int i = 0; i < massiv.Length; i++) //перебрала массив
            {

                if (n < massiv[i])
                {
                    n = massiv[i]; //если число массива больше n, то заменяю его

                }

            }
            Console.WriteLine($"Наибольшее число в массиве:{n}");
            return 0;
        }
        static void Main(string[] args)
        {
            double[] massiv = { 2.4, 2.1, 6.4, 25.87, 2.123 }; //сделала массив, цифры в нем можно изменять и добавлять
            Console.Write("Введите число n:");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            metod(massiv, n); //
        }
    }
}
