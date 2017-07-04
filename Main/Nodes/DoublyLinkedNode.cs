using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    class DoublyLinkedNode
    {
        private int data;
        private DoublyLinkedNode nextNode;
        private DoublyLinkedNode prevNode;
        
        public DoublyLinkedNode(int data)
        {
            this.data = data;
        }

        public int GetData()
        {
            return data;
        }

        public void SetData(int newData)
        {
            data = newData;
        }

        public DoublyLinkedNode GetNextNode()
        {
            return nextNode;
        }

        public DoublyLinkedNode GetPreviousNode()
        {
            return prevNode;
        }

        public void SetNextNode(DoublyLinkedNode newNode)
        {
            nextNode = newNode;
        }

        public void SetPreviousNode(DoublyLinkedNode newNode)
        {
            prevNode = newNode;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }
    }
}
