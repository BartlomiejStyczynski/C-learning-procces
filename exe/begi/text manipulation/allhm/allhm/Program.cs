




//2 - Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, without supplying an input, exit immediately;
//otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.



//3 - Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00). A valid time should be between 00:00 and 23:59.
//                If the time is valid, display "Ok"; otherwise, display "Invalid Time".If the user doesn't provide any values, consider it as invalid time.



//4 - Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase.For example,
//                if the user types: "number of students", display "NumberOfStudents".Make sure that the program is not dependent on the input.So, if the user types "NUMBER OF STUDENTS",
//            the program should still display "NumberOfStudents".



//5 - Write a program and ask the user to enter an English word.Count the number of vowels(a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
using System;
using System.Collections.Generic;

namespace allhm
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

            elements.Sort();

            for (int i = 1; i < elements.Count-1; i++)
            {
                if (elements[i] > elements[i-1])
                    isConsecutive = true;
                else
                    isConsecutive = false;
            }


            var msg = isConsecutive ? "COnsecutive" : "Not consecutive";

            Console.WriteLine(value: msg);
        }
    }
}
