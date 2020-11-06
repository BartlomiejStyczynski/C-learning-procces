using System;
using System.Linq;

namespace Simplified_Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Simplify("8/4"));
        }

        public static string Simplify(string str)
        {
            var numbers = str.Split('/');
            var x = Convert.ToInt32(numbers[0]);
            var y = Convert.ToInt32(numbers[1]);
            int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

            if (x % y == 0)
                return y > x ? "1" + "/" + (y / x).ToString() : (x / y).ToString();

            foreach (int number in primes)
            {

                if (x % number == 0 && y % number == 0)
                {
                    if (!primes.Contains(x) || !primes.Contains(y))
                    {

                    return Simplify((x / number).ToString() + "/" + (y / number).ToString());
                    }
                    else
                        return (x / number).ToString() + "/" + (y / number).ToString();
                }

            }

            return str;
        }
    }
}
 