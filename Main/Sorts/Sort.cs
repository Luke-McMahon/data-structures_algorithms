using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    // TODO: Make generic
    public class Sort
    {
        public static void BubbleSort(int[] arr)
        {
            Console.WriteLine("Unsorted: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }

            Console.WriteLine("Sorted: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }

            Console.WriteLine();
        }

        public static void SelectionSort(int[] arr)
        {
            Console.WriteLine("Unsorted: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }

            Console.WriteLine();

            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length - 2; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < arr.Length - 1; j++)
                    {
                        if (arr[j] < arr[minIndex])
                            minIndex = j;
                    }
                    int temp = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = temp;
                }

                Console.WriteLine("Sorted: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(" " + arr[i]);
                }
            }

            Console.WriteLine();
        }

        

        public static void InsertionSort(int[] arr)
        {
            Console.WriteLine("Unsorted: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();

            for (int i = 0; i <= arr.Length - 1; i++)
            {


                int current = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = current;
            }

            Console.WriteLine("Sorted: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }

            Console.WriteLine();
        }

        private static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}

