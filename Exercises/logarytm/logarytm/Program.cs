using System;
using System.Collections.Generic;

namespace logarytm
{
    class Program

    {

        public class logus
        {
            public double ID { get; set; }
            public double Wyni { get; set; }
        }

        static void Main(string[] args)
        {
            
            var kust = new List<logus>();
            for (int i = 0; i < 1500; i++)
            {
                var nie = Math.Log2(615 + (i * i));
                if (nie%1 == 0)
                    Console.WriteLine(i); ;
            }
            foreach (var item in kust)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
