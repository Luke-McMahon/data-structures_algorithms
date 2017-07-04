using System;

namespace DataStructures_Algorithms
{
    class LinkedList<T>
    {
        private Node<T> head;

        public int Length
        {
            get
            {
                return GetLength();
            }
        }

        private int GetLength()
        {
            int length = 0;
            Node<T> current = this.head;

            while(current != null)
            {
                length++;
                current = current.GetNextNode();
            }

            return length;
        }

        public Node<T> Find(int data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.GetData().Equals(data))
                {
                    return current;
                }
                current = current.GetNextNode();
            }

            return null;
        }
        
        public void InsertAtHead(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.SetNextNode(this.head);
            this.head = newNode;
        }

        public void DeleteFromHead()
        {
            this.head = this.head.GetNextNode();
        }       

        public override string ToString()
        {
            string result = "{";
            Node<T> current = this.head;

            while(current != null)
            {
                result += current.ToString() + ", ";
                current = current.GetNextNode();
            }
            result += "}";
            return result;
        }
    }
}
