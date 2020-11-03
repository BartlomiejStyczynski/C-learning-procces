using System;

namespace How_Many_Solutions_Does_This_Quadratic_Have
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int solutions(int a, int b, int c)
        {
            var delta = (b * b) - 4 * a * c;

            int value;
            if (delta < 0)
                return 0;

            return value = delta > 0 ? 2 : 1;        }
    }
}
