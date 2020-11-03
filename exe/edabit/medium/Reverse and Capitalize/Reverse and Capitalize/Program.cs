using System;
using System.Linq;

namespace Reverse_and_Capitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string ReverseCapitalize(string str)
        {
           var reversed = new string(str.Reverse().ToArray());

            return reversed.ToUpper();
        }
    }
}
