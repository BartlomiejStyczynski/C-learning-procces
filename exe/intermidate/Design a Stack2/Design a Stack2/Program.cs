
//Design a class called Stack with three methods.
//void Push(object obj)
//object Pop()
//void Clear()

using System;

namespace Design_a_Stack2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);


            stack.Pop();
            stack.Pop();
            stack.Pop();



        }
    }

}
