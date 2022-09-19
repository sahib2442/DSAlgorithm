using System;
namespace InsertionSort
{
    class program
    {
        public static void Master(string[] args)
        {
            int[] arr = new int[4] {2,3,1,4};
            int n = 4, i;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}




