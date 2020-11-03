using System;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            while(true)
            {
                Console.WriteLine("Eneter few numbers separated by a hyphen");
                var input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                    break;
                Console.WriteLine("Enter again");

            }


        }
    }
}
