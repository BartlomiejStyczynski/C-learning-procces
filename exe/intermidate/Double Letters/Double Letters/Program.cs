using System;
using System.Collections.Generic;

namespace Double_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool DoubleLetters(string word)
        {
            bool output = false;
            var newList = new List<char>();
            foreach (var character in word)
            {
                newList.Add(character);
            }

            for (int i = newList.Count; i > 0; i--)
            {
                if(newList[i] == newList[i-1])
                {
                    break;
                }
            }

            return output;
        }
    }
}
