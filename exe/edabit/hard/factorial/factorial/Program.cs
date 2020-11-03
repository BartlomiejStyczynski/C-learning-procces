using System;

//Create a function that takes an integer and returns the factorial of that integer.That is, the integer multiplied by all positive lower integers.

namespace factorial
{
    class Program
    {
        public static int Factorial(int num)
        {
            var factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
