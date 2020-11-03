using System;

namespace Letters_Only
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LettersOnly("R!=:~0o0./c&}9k`60=y"));
        }
        public static string LettersOnly(string str)
        {
            string output = null;
            foreach (var character in str)
            {
                
                if (System.Char.IsLetter(character))
                    output += character;
                
            }
            return output;
        }
    }
}
