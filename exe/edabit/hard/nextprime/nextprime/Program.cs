using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace nextprime
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Fact(4));

            //Create a Fact method that receives a non-negative integer and returns the factorial of that number.


        }

        public static long Fact(int n)
        {
            long number = 1;
            for (int i = n; i > 0; i--)
            {
                if (n == 0)
                    return 1;
                number *= i;
                
            }
            return number;
        }

    }

}
