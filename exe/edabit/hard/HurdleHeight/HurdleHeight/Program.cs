//Create a function that takes an array of hurdle heights and a jumper's jump height, and determine whether or not the hurdler can clear all the hurdles.

//A hurdler can clear a hurdle if their jump height is greater than or equal to the hurdle height.
using System;
using System.Linq;

namespace HurdleHeight
{
    class Program
    {
        public static bool hurdleJump(int[] hurdles, int jumpHeight)
        {
            var canJump = true;

            foreach (var hurdle in hurdles)
            {
                if (jumpHeight < hurdle)
                    canJump = false;
            }

            return canJump;
          

        }

        static void Main(string[] args)
        {
            hurdleJump([1, 2, 3, 4, 5], 5);
            Console.WriteLine();
        }
    }
}
