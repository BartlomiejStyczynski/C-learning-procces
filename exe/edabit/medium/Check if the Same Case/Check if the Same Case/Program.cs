//Create a function that returns true if an input string contains only uppercase or only lowercase letters.

//Examples
//SameCase("hello") ➞ true

//SameCase("HELLO") ➞ true

//SameCase("Hello") ➞ false

//SameCase("ketcHUp") ➞ false

using System;
using System.Runtime.InteropServices;

namespace Check_if_the_Same_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SameSpace()
        }
    }
    public static bool SameCase(string str)
    {
        bool output;
        for (int i = str.Length; i > 0; i--)
        {
            if ((Char.IsLower(str[i]) && Char.IsLower(str[i - 1]) || (Char.IsUpper(str[i]) && char.IsUpper(str[i - 1]))))
            {
                output = true;

            }

            else

            {
                output = false;
                return output;
            }
            return output;
        }

    }
}
