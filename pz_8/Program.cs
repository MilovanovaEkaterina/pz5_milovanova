using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int lastZeroQuantity = 0;
            int[] A = new int[50];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(20, 100);
                if (A[i] % 10 == 0)
                {
                    lastZeroQuantity++;
                }
            }

            foreach (int n in A)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();




            if (lastZeroQuantity != 0)
            {
                Console.WriteLine("Числа оканчивающиеся на 0");

                int[] B = new int[lastZeroQuantity];

                int j = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] % 10 == 0)
                    {
                        B[j] = A[i];
                        j++;
                    }
                }

                foreach (int n in B)
                {
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("Чисел оканчивающийся на 0 нет");
            }
        }
    }
}
