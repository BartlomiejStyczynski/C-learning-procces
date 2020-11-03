using System;
using System.Linq;


namespace Reverse_the_Order_of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("japeirdole"));
        }

        public static string Reverse(string str)
        {
            string output = null;
            for (int i = str.Length-1; i > 0; i--)
            {
                output += str[i];
            }
            return output;
        }

    }
}
