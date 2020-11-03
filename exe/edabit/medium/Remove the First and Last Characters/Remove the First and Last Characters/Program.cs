using System;

namespace Remove_the_First_and_Last_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string RemoveFirstLast(string str)
        {
            return str.Length >= 2 ? str.Substring(1, str.Length -2) : str;
        }
    }
}
