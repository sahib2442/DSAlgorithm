﻿using System;
using System.ComponentModel;

namespace BubbleSort
{
    class BubbleSortt
    {
        static void Main(string[] args)
        {
            int[] arr = { 2,3,1,4 };
            int temp;
            for (int i= 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
