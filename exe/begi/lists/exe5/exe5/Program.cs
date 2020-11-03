using System;
using System.Collections.Generic;

namespace exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

            string[] elements;
            
            Console.WriteLine("Enter 5 numbers sep with comas");


            while (true) 
            {
                var input = Console.ReadLine();
                if (!String.IsNullOrEmpty(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid list");
            }

            var numbers = new List<int>();
            
            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            numbers.Sort();

            for (int q = 0; q <= 2 ; q++)
            {
                Console.WriteLine(numbers[q]);
            }



            



            
        }
    }
}
