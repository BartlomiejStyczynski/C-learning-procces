//Create a function that takes a single character as an argument and returns the char code of its lowercased / uppercased counterpart.

//Examples
//Given that:
//  - "A" char code is: 65
//  - "a" char code is: 97

//CounterpartCharCode("A") ➞ 97

//CounterpartCharCode("a") ➞ 65

using System;
using System.Globalization;

namespace Find_the_Characters_Counterpart_Char_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();


            public static int CounterpartCharCode(char symbol)
            {
                if (Char.IsLower(symbol))
                {
                    return Convert.ToInt32(Char.ToUpper(symbol));

                }

                else
                {
                    return Convert.ToInt32(Char.ToLower(symbol));
                }

                   
               
            }
        }
    }
}
