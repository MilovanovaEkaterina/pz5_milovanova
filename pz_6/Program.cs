using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("Введите число");
int k=Convert.ToInt32(Console.ReadLine());
double l = 1.0;
for(int y=2;y<k+1;y++)
{
l += (1 /Convert.ToDouble(y));
}
Console.WriteLine(l);


        }
    }
}
