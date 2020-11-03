using System;
using System.Text;

namespace Burrrrrrrp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongBurp(6));
        }

        public static string LongBurp(int b)
        {
            var amoundOfRs = new StringBuilder();
            var rS = amoundOfRs.Append('r', b).ToString() ;

            return "Br" + rS + "p";

            

        }
    }
}
