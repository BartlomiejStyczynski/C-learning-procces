using System;
using System.Collections.Generic;

namespace public_class_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void SockPairs(string socks)
        {
            int pairs = 0;
            var lista = new List<char>();
            foreach (var character in socks)
            {
                lista.Add(character);
            }

            lista.Sort();

            for (int i = 0; i < lista.Count-1; i++)
            {
                if(lista[i+1] == lista[i])
                {
                    pairs++;

                }
            }
            
            
            

            
        }
    }
}
