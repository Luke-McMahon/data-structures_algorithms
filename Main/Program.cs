using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures_Algorithms;
using DataStructures_Algorithms.Sorts;
using DataStructures_Algorithms.Stack;


namespace DataStructures_Algorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Sorts();
            Console.ReadKey();
        }

        private static void Assignments()
        {
            Assignment3 assign = new Assignment3();
            assign.Init();
        }

        private static void Sorts()
        {
            Random rand = new Random();
            int a = rand.Next(7, 15);
            int[] arr = new int[a];
            for (int i = 0; i < a; i++)
            {
                arr[i] = rand.Next(20);
            }
            Console.WriteLine("BubbleSort");
            Sort.BubbleSort(arr);

            Console.WriteLine();

            Console.WriteLine("InsertionSort");
            Sort.InsertionSort(arr);

            Console.WriteLine();

            Console.WriteLine("SelectionSort");
            Sort.SelectionSort(arr);
        }
    }
}
