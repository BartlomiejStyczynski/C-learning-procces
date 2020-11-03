using System;

namespace Multiply_by_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }

        public static int[] MultiplyByLength(int[] arr)
        {
            var output = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                output[i] = arr[i] * arr.Length;
            }
            return output;
        }
    }
}
