using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] arr = new double[6, 7];
            var s = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    arr[i, j] = (double)s.Next(100) / 10;
                }
            }
        }

    }
}
