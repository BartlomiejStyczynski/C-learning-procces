using System;

namespace exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 - Write a program and ask the user to enter an English word.Count the number of vowels(a, e, o, u, i) 
            //    in the word. So, if the user enters "inadequate", the program should display 6 on the console.
            var forbiddenChars = new char[] { 'a', 'e', 'o', 'u', 'i' };
            var count = 0;
            Console.WriteLine("Eneter a word");

            var input = Console.ReadLine().ToLower();


            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < forbiddenChars.Length; j++)
                {
                    if (input[i] == forbiddenChars[j])
                        count++;
                }
            }


            Console.WriteLine("There is {0} vowels", count);
            


        }
    }
}
