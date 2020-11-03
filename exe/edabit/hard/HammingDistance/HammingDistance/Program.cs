using System;
using System.Collections.Generic;
using System.Threading;

namespace HammingDistance
{
    class Program
    {
        public static int HammingDistance(string str1, string str2)
        {
            int count = 0;
            var list1 = new List<char>();
            var list2 = new List<char>();

            foreach (var ch in str1)
            {
                list1.Add(ch);
            }

            foreach (var ch in str2)
            {
                list2.Add(ch);
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                {
                    count++;
                }

            }

            return count;

 
        }

        static void Main(string[] args)
        {
            Console.WriteLine(HammingDistance("abcde", "bcdef"));
        }
    }
}
