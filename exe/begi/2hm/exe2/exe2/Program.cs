using System;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            var count = 0;

            while(Console.ReadLine() != "ok")
            {
                Console.WriteLine(count);
                var number = Convert.ToInt32(Console.ReadLine());
                count+= number;
                
                

            }

            Console.WriteLine("good bye");

            
        }
    }
}
