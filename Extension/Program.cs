using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ms = new int[] { 6, 3, -1, 3, 4 };
           
            Console.WriteLine("Before sort:");
            foreach (int i in ms)
                Console.Write(i + " ");
            
            int[] new_ms = new int[5];
            new_ms = ms.ArraySort();
            Console.WriteLine("\nAfter sort(asc):");
            foreach (int i in new_ms)
                Console.Write(i + " ");
            Console.WriteLine();
            new_ms = ms.ArraySortDesc(true);

            Console.WriteLine("After sort(desc):");
            foreach (int i in new_ms)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }

    public static class IntArrayExtension
    {
        public static int[] ArraySort(this int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        public static int[] ArraySortDesc(this int[] arr, bool desc)
        {
            if (desc == false)
                return arr.ArraySort();
            else
            {
                int temp = 0;
                for (int i = 0; i < arr.Length-1; i++)
                {
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                return arr;
            }
        }
    }
}
