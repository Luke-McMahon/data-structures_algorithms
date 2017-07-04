using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    class DoublyLinkedListDemo
    {
        public static void Init()
        {
            DoublyLinkedList ints = new DoublyLinkedList();
            ints.InsertAtHead(5);
            ints.InsertAtHead(10);
            ints.InsertAtHead(2);
            ints.InsertAtHead(12);
            ints.InsertAtHead(19);
            ints.InsertAtHead(20);

            Console.WriteLine(ints);
            Console.WriteLine(ints.Length);
        }
    }
}
