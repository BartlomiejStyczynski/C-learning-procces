using System;

namespace Vowel_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceVowels("minnie mouse", "?"));
        }
        public static string ReplaceVowels(string str, string ch)
        {
            var vowels = new[] { "a", "e", "u", "i", "o", "j" };
            for (int i = 0; i < vowels.Length - 1; i++)
            {
                str = str.Replace(vowels[i], ch);
            }
            return str;
        }
    }
}
