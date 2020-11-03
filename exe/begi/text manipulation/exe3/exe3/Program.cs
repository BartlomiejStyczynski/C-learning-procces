using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 - Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase. 
            //    For example, if the user types: "number of students", display "NumberOfStudents".Make sure that the program is not dependent 
            //    on the input.So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            Console.WriteLine("Enter fwe words sep byt a space");

            var input = Console.ReadLine().Trim();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var toPascal = "";

            foreach (var word in input.Split(' '))
            {
                var configured = char.ToUpper(word[0]) + word.ToLower().Substring(1);

                toPascal += configured;
            }

            Console.WriteLine(toPascal);






            











        }
    }
}
