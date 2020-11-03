using System;
using System.Linq;

namespace Is_the_Average_of_All_Elements_a_Whole_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsAvgWhole(int[] arr)
        {
            return arr.Average() % 1 == 0;
        }
    }
}
