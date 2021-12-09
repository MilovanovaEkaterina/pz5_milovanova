using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "быть или не быть вот в чем вопрос";
            Console.WriteLine(ReverseWords(str));
            Console.ReadKey();
        }
        static string ReverseWords(string str)
        {
            string[] words = str.Split();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = new string(words[i].Reverse().ToArray());
            }
            return string.Join(" ", words);
        }
    }
}
