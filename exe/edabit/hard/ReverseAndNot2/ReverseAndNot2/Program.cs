using System;
using System.Linq;
using System.Reflection.Metadata;

namespace ReverseAndNot2
{

        class Program
    {
        static void Main(string[] args)
        {
            //    Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.

            //string reversedString = null;
            //Console.WriteLine("give us a number");

            //var inputString = Console.ReadLine();

            //for (int i = 1; i < inputString.Length; i++)
            //{
            //    reversedString += inputString[inputString.Length - i];
            //}

            //var combined = reversedString + inputString;
            //Console.WriteLine(combined);
            string output;

            var intigerInput = Convert.ToInt32(Console.ReadLine());

            var reversed = intigerInput.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0'); ;

            output = reversed.ToString() + intigerInput.ToString();

            Console.WriteLine(output);
            
            
            







        }
    }
}
