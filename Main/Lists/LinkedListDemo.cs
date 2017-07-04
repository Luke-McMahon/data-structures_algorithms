using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    class LinkedListDemo
    {
        public static void Init()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.InsertAtHead(5);
            list.InsertAtHead(10);
            list.InsertAtHead(2);
            list.InsertAtHead(12);
            list.InsertAtHead(19);
            list.InsertAtHead(20);

            list.DeleteFromHead();

            //Console.WriteLine(list);
            //Console.WriteLine("Length: " + list.Length);
            Console.WriteLine("Found: " + list.Find(15));
        }
    }
}
