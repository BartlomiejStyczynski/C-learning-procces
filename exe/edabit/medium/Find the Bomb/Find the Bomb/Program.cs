using System;

namespace Find_the_Bomb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bomb("there is a bomb"));
        }
        public static string Bomb(string txt)
        {
            if (txt.ToLower().Contains("bomb"))
                {
                return "Duck!!!";
            }
            else
                return "There is no bomb, relax.";
                        
        }
    }
}
