using System;

namespace Stuttering_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Stutter(string word)
        {
            var stutter = word.Substring(0, 2) + new string('.', 3) + " ";
            return stutter + stutter + word + "?";
        }
    }
}
