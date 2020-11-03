using System;

namespace The_Collatz_Conjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(collatz(6));
        }

        public static int collatz(int num)
        {
            int steps = 0;
            while (num != 1)
            {
                 
                steps++;
                if (num % 2 == 0)
                    num = num / 2;
                else
                    num = num * 3 + 1;

                steps += 1;
               
            }
            return steps;
         }
    }
}
