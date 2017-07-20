using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Stack
{
    internal class Stack<T>
    {
        private const int MAX_SIZE = 9;
        private T[] stackArray;
        private int top = -1;

        public void Init()
        {
            stackArray = new T[MAX_SIZE];
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
