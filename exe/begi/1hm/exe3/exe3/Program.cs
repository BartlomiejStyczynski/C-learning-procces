using System;

namespace exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

            Console.WriteLine("give us width of pic");

            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("gives us height");

            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width.CompareTo(height);

            if(orientation == 1 )
            {
                Console.WriteLine("It's a lnadscape");
            }

            else
            {
                Console.WriteLine("It's a portrait");
            }

        }
    }
}
