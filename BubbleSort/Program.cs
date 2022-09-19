using System;
using System.ComponentModel;

namespace BubbleSort
{
    class BubbleSort
    {
        static void Master(string[] args)
        {
            int[] arr = { 2, 3, 1, 4 };
            int temp;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                Console.WriteLine("Sorted:");
                foreach (int p in arr)
                Console.Write(p + " ");
                Console.Read();
            }
        }
    }
}

