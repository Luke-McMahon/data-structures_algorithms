using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    class Node
    {
        private int data;
        private Node nextNode;

        public Node(int data)
        {
            this.data = data;
        }

        public int GetData()
        {
            return data;
        }

        public Node GetNextNode()
        {
            return nextNode;
        }

        public void SetData(int data)
        {
            this.data = data;
        }

        public void SetNextNode(Node nextNode)
        {
            this.nextNode = nextNode;
        }
    }
}
