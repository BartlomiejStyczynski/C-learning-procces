using System;
using System.Buffers;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 - Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.Display the reversed name on the console.

            
            var input = Console.ReadLine();
            var lenght = input.Length;
            var reversedArray = new char[lenght];


            
            

            for(var i = 0; i < lenght; i++)
            {
                reversedArray[i] = input[(lenght - 1) - i];

            }


            var reversed = new string(reversedArray);

            Console.WriteLine(reversed);

            


            

        }
    }
}
