using System;

using System.Linq;
using System.Threading;

namespace SortSummAscending
{
    class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
            var reversed = new int[arr.Length];

            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[(arr.Length - 1) - i];
            }

            return reversed;

        }

        static void Main(string[] args)
        {
            int[] intArray = new int[5] { 8, 10, 2, 6, 3 };

            

            foreach (var item in SortNumsAscending(intArray))
            {
                Console.WriteLine(item);
            }
        }
    }
}
