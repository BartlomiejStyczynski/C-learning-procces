using System;
using System.Collections;
namespace Equality_of_3_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Equal(3, 3, 3));
        }
        public static int Equal(int a, int b, int c)
        {
            var nova = new int[] { a, b, c };
            var novaLista = new ArrayList();
            
            foreach (var item in nova)
            {
                if (!novaLista.Contains(item))
                    novaLista.Add(item);
            }

            return novaLista.Count;
        }

    }
}
