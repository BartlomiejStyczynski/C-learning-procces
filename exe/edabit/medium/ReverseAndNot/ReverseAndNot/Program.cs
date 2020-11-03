using System;
using System.Linq;
using System.Collections.Generic;


namespace ReverseAndNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseAndNot(123));
        }

        public static string ReverseAndNot(int i)
        {
            var reversed = new List<int>();
            for (int j = i.ToString().Length-1; j >= 0 ; j--)
            {
                reversed.Add(i.ToString()[j]);
            }

            return reversed.ToString();
        }
    }
}
