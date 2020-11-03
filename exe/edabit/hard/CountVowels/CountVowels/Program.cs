using System;
using System.Linq;

namespace CountVowels
{
    class Program
    {

        
        public static int CountVowels(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            var count = 0;
            foreach (var ch in str)
            {
                if (vowels.Contains(ch))
                {
                    count++;
                }
            }

            return count;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(CountVowels("Palm"));
        }
    }


}
