using System;

namespace Recursion_to_Repeat_a_String_n_Number_of_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Repetition("Hello World!", 3));
        }

        public static string Repetition(string txt, int n)
        {
            
            if (n < 1)
                return txt;
            else
            {
                return txt + Repetition(txt, n - 1);
            }
                
        }
    }
}
