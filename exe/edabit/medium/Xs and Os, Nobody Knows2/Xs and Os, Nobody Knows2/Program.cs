using System;
using System.Linq;

namespace Xs_and_Os__Nobody_Knows2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool XO(string str)
        {
            var xCount = 0;
            var oCount = 0;
            foreach (var character in str.ToLower())
            {
                if (character == 'x')
                    xCount++;
                if (character == 'o')
                    oCount++;   
            }
            return xCount == oCount ? true : false;

            
        }
    }
}
