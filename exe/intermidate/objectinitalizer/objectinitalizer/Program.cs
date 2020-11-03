using System;

namespace objectinitalizer
{

    class Program
    {
        static void Main(string[] args)
        {

            //var number = int.Parse("abc");

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine("valid input");
            else
                Console.WriteLine("invalid");

            
        }

        static void UseParams()
        {
            var calculator = new Calculator();

            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6, 7));
        }


    }


}
