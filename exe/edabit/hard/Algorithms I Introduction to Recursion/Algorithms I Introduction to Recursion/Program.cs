using System;

namespace Algorithms_I_Introduction_to_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
        }

        public static int factorial(int num)
        {
            if (num <= 1)
                return num;
            else
                return num * factorial(num - 1);
        }
    }
}
