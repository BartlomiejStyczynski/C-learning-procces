using System;

namespace smaller_nmb
{
    class Program
    {
        public static string smallerNum(string n1, string n2)
        {
            numberOne = Convert.ToInt32(n1);
            numberTwo = Convert.ToInt32(n2);

            if (numberOne >= numberTwo)
                return numberTwo;
            else
                return numberOne;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
