using System;
using System.Collections.Generic;

namespace Block_the_square_in_Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int BlockPlayer(int a, int b)
        {
            var numbers = new int[] { a, b };
            var colums1 = new int[] { 0, 1, 2 };

            var rows1 = new int[] { 0, 3, 6 };

            var topbottom = new int[] { 0, 4, 8 };
            var bottomtop = new int[] { 2, 4, 6 };

            Array.Exists<int>(colums1, element => element == numbers);

            





        }
    }
}
