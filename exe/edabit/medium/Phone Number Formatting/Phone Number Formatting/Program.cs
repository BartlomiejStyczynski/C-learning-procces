using System;
using System.Linq;

namespace Phone_Number_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            var newNumbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};


            Console.WriteLine(FormatPhoneNumber(newNumbers));
        }
        public static string FormatPhoneNumber(int[] numbers)
        {
            

            

            return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers.Select(x => x.ToString()).ToArray());
        }



    }

}
