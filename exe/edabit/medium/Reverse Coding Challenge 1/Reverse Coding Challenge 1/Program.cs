using System;

namespace Reverse_Coding_Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MysteryFunc("A4B5C2"));
        }
        public static string MysteryFunc(string str)
        {
            string outputString = null;
            for (int i = 0; i < str.Length; i+=2)  
                for (int j = 0; j < System.Char.GetNumericValue(str[i + 1]); j++)
                {
                    outputString += str[i];
                }


            return outputString;
        }
    }
}
