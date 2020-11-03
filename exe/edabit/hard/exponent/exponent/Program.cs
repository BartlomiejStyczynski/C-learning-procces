using System;

namespace exponent
{
    class Program
    {
        public static long CalculateExponent(long number, long exponent)
        {

            return  Convert.ToInt64(Math.Pow(Convert.ToDouble(number), Convert.ToInt32(exponent)));
        }


        static void Main(string[] args)
        {
            Console.WriteLine(CalculateExponent(10, 10));
        }
    }
}
