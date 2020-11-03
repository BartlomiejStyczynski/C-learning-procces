using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(LastDig(25, 20, 32));
        }
        static bool LastDig(int a, int b, int c)
        {
            int d = Math.Abs(a % 10);
            int e = Math.Abs(b % 10);
            int f = Math.Abs(c % 10);

            return d * e == f;

        }
    }
}
