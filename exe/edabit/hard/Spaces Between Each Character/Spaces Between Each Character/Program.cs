using System;
using System.Collections.Generic;

using System.Linq;
namespace Spaces_Between_Each_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpaceMeOut("far out"));
        }
        public static string SpaceMeOut(string str)
        {
            return String.Join(' ', str.ToArray());
        }
    }
}
