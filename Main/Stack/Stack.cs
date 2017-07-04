using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Stack
{
    class Stack<T>
    {
        int maxSize = 9;
        T[] stackArray;
        int top = -1;

        public void Init()
        {
            stackArray = new T[maxSize];
        }
        
        public void Push(T data)
        {
            top++;
            stackArray[top] = data;
        }

        public T Pop()
        {
            T result = stackArray[top];
            top--;
            return result;
        }

        public T Peek()
        {
            return stackArray[top];
        }
    }
}
