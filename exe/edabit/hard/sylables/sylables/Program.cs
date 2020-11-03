using System;
using System.Threading;

namespace sylables
{
    class Program
    {
        public static int NumberSyllables(string word)
        {
            int count = 1;
            foreach (var character in word)
            {
                if (character == '-')
                    count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
