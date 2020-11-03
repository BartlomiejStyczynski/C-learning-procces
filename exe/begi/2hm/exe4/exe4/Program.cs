using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace exe4
{
    class Program
    {
        static void Main(string[] args)
        {

            // 5- Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

           
            var imput = Console.ReadLine().Split(',');

            var max = Convert.ToInt32(imput[0]);

            foreach(var c in imput)
            {
                var number = Convert.ToInt32(c);
               if(number > max)
                    max = number;
         

            }

            Console.WriteLine(max);


            
            
        }

    }
}
