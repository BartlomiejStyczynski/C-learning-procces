using System;
using System.Globalization;

////Create a function that takes a number(from 1 to 12) and returns its corresponding month name as a string. For example, if you're
//given 3 as input, your function should return "March", because March is the 3rd month.
namespace monthname
{
    class Program
    {
        public static string MonthName(int num)
        {

            var name = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);
            return name;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MonthName(11));
        }
    }
}
