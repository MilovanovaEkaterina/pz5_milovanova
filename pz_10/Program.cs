using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            
            double[][] arr = new double[3][];

            arr[0] = new double[rand.Next(10, 30)];
            arr[1] = new double[rand.Next(10, 30)];
            arr[2] = new double[rand.Next(10, 30)];


            
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = r.Next(10, 30);
                }
            }

            
            Console.WriteLine("Ступенчатый массив");

            foreach (double[] row in arr)
            {
                foreach (double s in row)
                {
                    Console.Write($"{s} ");
                }
                Console.WriteLine();
            }

            
            double[] lastVals = new double[arr.Length];

            for (int i = 0; i < lastVals.Length; i++)
            {
                lastVals[i] = arr[i][^1];
            }

            
            Console.Write("\nПоследние элементы каждой строки: ");
            foreach (double ch in lastVals)
            {
                Console.Write($"{ch} ");
            }

            
            double[] maxVals = new double[arr.Length];

            for (int i = 0; i < maxVals.Length; i++)
            {
                double maxD = arr[i][0];
                for (int k = 0; k < arr[i].Length; k++)
                {
                    if (arr[i][k] > maxD)
                        maxD = arr[i][k];
                }
                maxVals[i] = maxD;
            }

            Console.Write("\nСтаршие элементы каждой строки: ");
            foreach (double ch in maxVals)
            {
                Console.Write($"{ch} ");
            }
            Console.WriteLine();

            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i][Array.IndexOf(arr[i], maxVals[i])] = arr[i][0];
                arr[i][0] = maxVals[i];
            }

            Console.WriteLine("\nОбновлённый массив");
            foreach (double[] row in arr)
            {
                foreach (double ch in row)
                {
                    Console.Write($"{ch} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
