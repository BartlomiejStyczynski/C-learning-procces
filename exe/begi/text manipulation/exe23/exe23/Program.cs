using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace exe23
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            bool isDuplicate = false;
            Console.WriteLine("Eneter few numbers separated byt a hyphen");

            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            numbers.Sort();

            for (int i = 1;  i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                    isDuplicate = true;
            }

            var msg = isDuplicate ? "Duplicates" : "No Duplicates";
            Console.WriteLine(msg);
        }
    }
}
