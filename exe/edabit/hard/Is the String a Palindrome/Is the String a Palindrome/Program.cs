using System;
using System.Linq;

namespace Is_the_String_a_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //LINQ version
        public static bool CheckPalindrome(string str)
        {
            var reversed = new string(str.Reverse().ToArray());

            if (reversed == str)
                return true;
            else
                return false;

            
            
        }
    }
}
