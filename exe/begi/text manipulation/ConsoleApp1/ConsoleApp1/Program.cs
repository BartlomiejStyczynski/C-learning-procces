using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.Work out if the numbers are consecutive.For example,
            //                if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            bool isConsecutive = true;

            Console.WriteLine("write few numbers sep with hypen");

            var input = Console.ReadLine();



            var elements = new List<int>();

            foreach (var number in input.Split('-'))
            {
                elements.Add(Convert.ToInt32(number));
            }

            

            for (int i = 1; i < elements.Count; i++)
            {
                if (elements[i] > elements[i - 1])
                    isConsecutive = true;
                else
                    isConsecutive = false;
            }


            var msg = isConsecutive ? "COnsecutive" : "Not consecutive";

            Console.WriteLine(value: msg);
        }
    }
}
