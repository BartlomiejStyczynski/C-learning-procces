using System;
using System.Linq;

namespace Hashes_and_Pluses
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var character in HashPlusCount("#+++#+#++#"))
            {
                Console.WriteLine(@"Count is {0}", character);
            } 

        }
        public static int[] HashPlusCount(string s)
        {
            //int hashCount = 0;
            //int plustCount = 0;

            //foreach (var character in s)
            //{    
            //    if (character == '#')
            //        hashCount++;
            //    else if (character == '+')

            //        plustCount++;
            //}

            //return new int[] { hashCount, plustCount };


            return new int[] { s.Count(x => x == '#'), s.Count(x => x == '+') };



        }
    }
}
