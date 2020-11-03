using System;


namespace Power_Ranger
{
    //    Create a function that takes in n, a, b and returns the number of values raised to the nth power that lie in the range[a, b], inclusive.
    //// Remember that the range is inclusive.
    //a < b will always be true.

    class Program
    {

    
        static void Main(string[] args)
        {
            double n, a, b, i = 1;

            var input = Console.ReadLine().Split(',');

            n = Convert.ToDouble(input[0]);
            a = Convert.ToDouble(input[1]);
            b = Convert.ToDouble(input[2]);

            while (Math.Pow(i, n) >= a)
            {
                i++;  
            }

            Console.WriteLine(i);






        }
    }


}
