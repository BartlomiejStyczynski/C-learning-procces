using System;
using System.Collections.Generic;

namespace exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask
            //the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
            

            var listOfFive = new List<int>();


            while(listOfFive.Count < 5)
            {
                Console.Write("Enter number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (listOfFive.Contains(number))
                {
                    Console.WriteLine("You have entered number {0} aready", number);
                    continue;
                }

                listOfFive.Add(number);

            }

            listOfFive.Sort();

            foreach(var n in listOfFive)
            {
                Console.WriteLine(n);
            }


        }
    }
}
