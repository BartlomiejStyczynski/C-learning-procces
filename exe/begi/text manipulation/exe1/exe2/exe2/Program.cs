using System;
using System.Collections.Generic;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
            /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
            /// any duplicates. If so, display "Duplicate" on the console.
            /// </summary>
            /// 
            var numbers = new List<int>();
            int previous;
            bool isDuplicate = false;

            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;


                else
                {
                    var springNumeral = input.Split('-');
                    foreach (var item in springNumeral)
                    {
                        numbers.Add(Convert.ToInt32(item));
                    }

                    numbers.Sort();

                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        if (numbers[i] == numbers[i + 1])
                            isDuplicate = true;
                        else
                            isDuplicate = false;
                            
                    }

                    var msg = isDuplicate ? "Duplicate" : "No Duplicates";

                    Console.WriteLine(msg);

                        




                }








            }



        }
    }
}
