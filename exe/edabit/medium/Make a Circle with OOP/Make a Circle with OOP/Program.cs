using System;

namespace Make_a_Circle_with_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public class Circle
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                this.Radius = radius;

            }

            public double GetArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }

            public double GetPerimeter()
            {
                return 2 * Math.PI * Radius;
            }
        }

        //unquote and use run to test these cases
        //public class Program{
        //  public static void Main(int[] args){
        //    var q = new Circle(4.44);
        //    Console.WriteLine(q.GetArea());
        //    Console.WriteLine(q.GetPerimeter());
        //  }
        //}
    }
}
