using System;

namespace ReverseAndNot
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.

            string reversedString = null;
            Console.WriteLine("give us a number");

            var inputString = Console.ReadLine();

            for (int i = 0; i < inputString.Length; i++)
            {
                reversedString += "inputString[inputString.Length - i]";
            }



        }
    }
}
