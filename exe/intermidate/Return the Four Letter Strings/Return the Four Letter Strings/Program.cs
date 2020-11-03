using System;
using System.Collections.Generic;

namespace Return_the_Four_Letter_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string[] IsFourLetters(string[] arr)
        {
            var newList = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].Length == 4)
                {
                   newList.Add(arr[i]);
                }
  
            }

            return newList.ToArray();
            

        }
    }
}
