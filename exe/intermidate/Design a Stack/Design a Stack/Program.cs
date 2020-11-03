using System;

namespace Design_a_Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack();

            stack.Push(1);
            stack.Push("kuwra mac");
            stack.Push(3);

            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            

            

        }
    }
}
 