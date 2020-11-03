using System;

namespace exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.

            var count = 0;
            for(var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
