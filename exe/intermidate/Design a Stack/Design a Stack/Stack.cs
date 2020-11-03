using System.Collections;

namespace Design_a_Stack
{
    public class Stack
    {
        private ArrayList _stack = new ArrayList();

        public void Push(object obj)
        {
            _stack.Add(obj);
        }

        public object Pop()
        {
            object removed = _stack[_stack.Count - 1];
            _stack.Remove(_stack[_stack.Count - 1]);

            return removed;
        }

        public void Clear()
        {
            _stack.Clear();
        }

    }
}
 