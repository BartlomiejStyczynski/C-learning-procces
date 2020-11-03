using System;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 - Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.WriteLine("please give us first numer");

            var numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please give us second number");

            var numberTwo = Convert.ToInt32(Console.ReadLine());

            var comparision = numberOne.CompareTo(numberTwo);

            if (comparision == -1)
            {
                Console.WriteLine("{0} is smaller than {1}", numberOne, numberTwo);
            }



        }
    }
}
