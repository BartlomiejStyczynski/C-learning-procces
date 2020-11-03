using System;
using System.Linq;

namespace Consecutive_Numbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static bool Cons(int[] arr)
        {
            
            int[] ascending = arr.OrderBy(x => x).ToArray();

            for (int i = ascending.Length-1; i > 0; i--)
            {
                if(ascending[i] == ascending[i-1] || ascending[i] != ascending[i-1] +1)
                {
                    return false;
                }

            }
            return true;
        }
    }


}
 