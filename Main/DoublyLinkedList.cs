using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    class DoublyLinkedList
    {
        private DoublyLinkedNode head;

        public void InsertAtHead(int data)
        {
            DoublyLinkedNode newNode = new DoublyLinkedNode(data);
            newNode.SetNextNode(this.head);

            if(this.head != null)
            {
                this.head.SetPreviousNode(newNode);
            }
            this.head = newNode;
        }

        public int Length { get { return GetLength(); } }

        private int GetLength()
        {
            if (head == null)
                return 0;

            int result = 0;
            DoublyLinkedNode current = this.head;

            while(current.GetNextNode() != null)
            {
                result++;
                current = current.GetNextNode();
            }

            return result;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            DoublyLinkedNode n = this.head;

            while(n != null)
            {
                sb.Append("Node Data: ");
                sb.Append(n);
                sb.Append("\n");

                n = n.GetNextNode();
            }

            return sb.ToString();
        }
    }
}
