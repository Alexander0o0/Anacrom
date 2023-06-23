using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anacrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your first word: ");
            string first_word = Console.ReadLine();

            Console.WriteLine("Write your second word: ");
            string second_word = Console.ReadLine();

            char[] char1 = first_word.ToCharArray();
            char[] char2 = second_word.ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            Console.WriteLine(string.Concat(char1));
            Console.WriteLine(string.Concat(char2));

            if (string.Concat(char1) == string.Concat(char2))
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
        }
    }
}
