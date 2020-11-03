using System;
using System.Linq;

namespace Alphabet_Soup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static string AlphabetSoup(string str)
        {
            var character = str.ToCharArray();

            Array.Sort(character);

            return new string(character);
        }
    }
}
