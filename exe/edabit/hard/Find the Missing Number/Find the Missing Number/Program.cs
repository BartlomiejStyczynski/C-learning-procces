using System;

namespace Find_the_Missing_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MissingNum(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 5}));
        }
        public static int MissingNum(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i <= arr.Length-1; i++)
            {
                if (arr[i] != i + 1)
                    return i + 1;
            }
            return 10;            
        }

    }
}
