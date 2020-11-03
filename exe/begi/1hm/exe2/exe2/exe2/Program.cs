using System;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inter first number");

            var numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("give us second number");

            var numberTwo = Convert.ToInt32(Console.ReadLine());

            var comparision = numberOne.CompareTo(numberTwo);

            

            if (comparision == -1)
            {
                Console.WriteLine("{0} is smaller than {1}", numberOne, numberTwo);

            }
            else if (comparision == 1)
            {
                Console.WriteLine("{0} is greater than {1}", numberOne, numberTwo);
            }
            else
            {
                Console.WriteLine("both are equal");
            }


                
        }
    }
}
