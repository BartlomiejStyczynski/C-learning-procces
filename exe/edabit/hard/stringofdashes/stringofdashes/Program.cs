using System;

namespace stringofdashes
{
    class Program
    {
        public static string Go(int num)
        {
            string dashes = null;
            for (int i = 1; i <= num; i++)
            {
                dashes = dashes + "-";
            }

            return dashes;
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
        }
    }
}
