using System;
using System.Linq;
//Create a function that takes an array of numbers and returns the mean value.
namespace Calculate_the_Mean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static double Mean(int[] arr)
        {
            //double output = 0;

            //foreach (var number in arr)
            //{
            //    output += number;
            //}

            //return output / arr.Length;

            return arr.Average();
        }
    }
}
