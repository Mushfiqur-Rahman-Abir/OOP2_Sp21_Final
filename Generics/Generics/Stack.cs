using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Stack<S,X>
    {
        S[] arr;
        int peek;

        public Stack()
        {
            arr = new S[10];
        }
        public void Push(S a)
        {
            arr[peek++] = a;
        }

        public S Peek()
        {
            return arr[peek - 1];
        }

        public void Pop()
        {
            peek--;
        }
    }
}
