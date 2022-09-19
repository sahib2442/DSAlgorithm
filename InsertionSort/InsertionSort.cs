using System;
namespace InsertionSort
{
    public class InsertionSort
    {
        public static void Main(string[]args)
        { 
         int[] arr = new int[4] {2,1,3,4} ;
         int n = 4, i, j, val, flag;
         Console.WriteLine("Insertion Sort");
         Console.Write("Initial array is: ");
         for (i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
         for (i = 1; i < n; i++)
            {
            val = arr[i];
            flag = 0;
            for (j = i - 1; j >= 0 && flag != 1; )
                {
               if (val < arr[j]) {
                  arr[j + 1] = arr[j];
                  j--;
                  arr[j + 1] = val;
               }
               else flag = 1;
            }
         }
         Console.Write("\nSorted Array is: ");
         for (i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
      }
   }
}

