using System;

namespace A_Circle_and_Two_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int square_areas_difference(int radius)
        {
            return (int)Math.Pow((2 * radius), 2) - ((int)Math.Pow(2 * radius, 2) / 2);
        }
    }
}
