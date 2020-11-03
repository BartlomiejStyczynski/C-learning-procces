using System;

namespace Factorial_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(8));
        }

        public static long Fact(int n)
        {
            long output = 1;
            for (int i = 2; i <= n; i++)
            {
                output = output * i;
            }
            return output;
        }
    }
}
