using System;

namespace Re_Form_the_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetWord("di ", "pa"));
        }
        public static string GetWord(string left, string right)
        {
            
            return left[0].ToString().ToUpper() + left.Substring(1) + right;
        }
    }
}
