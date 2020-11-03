using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;

namespace LIST_SYNTAX
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARING A NEW LIST
            var number = new List<int>() { 1, 2, 3, 4 };


            //ADD & ADDRANGE METHOD
            number.Add(1);

            number.AddRange(new int[3] { 5, 6, 7 });
            //IndexOf()

            Console.WriteLine("Index of 1:" + number.IndexOf(1));

            //LastIndexOf()
            Console.WriteLine("Index of 1:" + number.LastIndexOf(1));


            // .Count

            Console.WriteLine("Lenght" + number.Count);


            // nie mozna uzywac foreach dla list, tylko for

            for(var i = 0; i < number.Count; i++)
            {
                if (number[i] == 1)
                    number.Remove(number[i]);

            }
            foreach(var n in number)
            {

                Console.WriteLine(number[n]);
            }






        }

    }
}
