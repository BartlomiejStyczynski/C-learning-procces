using System;
using System.Collections.Generic;

namespace Eliminate_Odd_Numbers_within_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoOdds({ 2, 5, 7, 5, 89, 123, 5232});
        }

        public static int[] NoOdds(int[] arr)
        {
            var numbers = new List<int>();

            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i]%2 == 0)
                {
                    numbers.Add(arr[i]);
                }
            }
            return numbers.ToArray();
        }

    }
}
