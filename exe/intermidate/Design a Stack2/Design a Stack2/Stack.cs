//Design a class called Stack with three methods.
//void Push(object obj)
//object Pop()
//void Clear()

using System.Collections.Generic;

namespace Design_a_Stack2
{
    public class Stack
    {
        public List<object> StackDesing { get; } = new List<object>();


        public void Push(object input)
        {
            if (input == null)
                throw new System.Exception("InvalidOperationException");
            StackDesing.Add(input);
        }
        
        public void Pop()
        {
            if (StackDesing == null)
                throw new System.Exception("InvalidOperationException.");

            System.Console.WriteLine(StackDesing[StackDesing.Count - 1]);
            StackDesing.Remove(StackDesing[StackDesing.Count - 1 ]);
        }
        public void Clear()
        {
            StackDesing.Clear();
        }
    }

}
