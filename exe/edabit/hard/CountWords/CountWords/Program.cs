using System;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountWords("japierdoledfas dgasdfg qwd  qdw qwd "));
        }
        public static int CountWords(string str)
        {
            var count = 0;
            var newStr = str.Split(' ');
            foreach (var word in newStr)
            {
                count++;
            }
            return count;
        }
    }
}
