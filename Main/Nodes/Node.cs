using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    class Node<T>
    {
        private T data;
        private Node<T> nextNode;

        public Node(T data)
        {
            this.data = data;
        }

        public T GetData()
        {
            return data;
        }

        public Node<T> GetNextNode()
        {
            return nextNode;
        }

        public void SetData(T data)
        {
            this.data = data;
        }

        public void SetNextNode(Node<T> nextNode)
        {
            this.nextNode = nextNode;
        }

        public override string ToString()
        {
            return "Data: " + this.data;
        }
    }
}
