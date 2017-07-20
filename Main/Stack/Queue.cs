using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Stack
{
    internal class Queue<T>
    {

        //private int maxSize = 8;
        private readonly T[] items;
        private int head = -1;
        private int tail = -1;
        private int numOfItems = 0;

        public Queue()
        {

        }

        public Queue(T item)
        {
            if(IsFull())
            {
                throw new Exception("Queue is full");
            }
            if(tail == items.Length - 1)
            {
                tail = -1;
            }

            items[++tail] = item;
            numOfItems++;
        }

        public T Peek()
        {
            return items[head + 1];
        }

        public void Enqueue(T data)
        {
            if (IsFull())
                throw new Exception("Queue is full");

            if(tail == items.Length-1)
            {
                tail = -1;
            }

            items[++tail] = data;
            numOfItems++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty");
            if(head == items.Length - 1)
            {
                head = -1;
            }
            numOfItems--;
            return items[++head];
        }
        
        private bool IsFull()
        {
            return numOfItems == items.Length;
        }

        private bool IsEmpty()
        {
            return numOfItems == 0;
        }
    }
}
