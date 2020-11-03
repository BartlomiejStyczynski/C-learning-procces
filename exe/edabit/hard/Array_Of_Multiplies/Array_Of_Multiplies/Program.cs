using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Array_Of_Multiplies
{
    class Program
    {
        public static int[] ArrayOfMultiples(int num, int length)
        {
            var mutipliedNumbers = new List<int>();

            for (int i = 1; i < length; i++)
            {
                mutipliedNumbers.Add(num * i);
            }
            return mutipliedNumbers.ToArray();
            
        }
                    
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayOfMultiples(5, 10));

           
        }
    }
}
