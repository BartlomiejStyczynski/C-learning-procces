using System;
using System.Collections.Generic;
using System.Globalization;

namespace listsexe5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

            string[] justNumbers;

            while (true)
            {
                Console.WriteLine("Eneter list of numbers seprated with comas");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    justNumbers = input.Split(',', ' ');
                    if (justNumbers.Length >= 5)
                        break;
                    
                }
                Console.WriteLine("Invalid list");
            }
                var numbers = new List<int>();
                foreach (var number in justNumbers)
                {
                    numbers.Add(Convert.ToInt32(number));
                }

                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            
        }
    }
}
