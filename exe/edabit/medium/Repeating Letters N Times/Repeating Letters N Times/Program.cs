using System;

namespace Repeating_Letters_N_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Repeat("dupa", 5));
        }

        public static string Repeat(string str, int num)
        {
            string output = null;

            foreach (var character in str)
            {
                output += new string(character, num);
            }

            return output;

        }
    }
}
