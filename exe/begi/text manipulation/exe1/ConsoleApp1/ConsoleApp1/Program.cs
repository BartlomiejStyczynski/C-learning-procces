using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.Work out if the numbers are consecutive.
            //    For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            var con = 0;
                var notcon = 0;
            var input = Console.ReadLine();

            var numbers = input.Split('-');

            var list = new List<int>();

            foreach (var number in numbers)
            {
                list.Add(Convert.ToInt32(number));
            }

            if (list[0] < list[list.Count-1])
                Console.WriteLine("It's consecutive");
            else
                Console.WriteLine("It's not");





        }
    }
}
