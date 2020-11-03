using System;
using System.Linq;

namespace Calculate_the_Mean2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mean(new int[] { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 }));
        }

        public static double Mean(int[] arr)
        {
            return Math.Round(arr.Average() / arr.Length, 2);
        }
    }
}
