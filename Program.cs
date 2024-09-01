﻿namespace sort
{
    internal class Program
    {
        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (i != min)
                {
                    int swap = arr[i];
                    arr[i] = arr[min];
                    arr[min] = swap;
                }
            }
            return arr;
        }
        public static int[] BubbleSort(int[] arr)
        {
            for (int j = arr.Length - 1; j > 0; j--)
            {
                bool swapped = false;
                for (int i = 0; i < j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            } 
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 5, 2, 7, 4, 0 };
            SelectionSort(arr);
            for(int i = 0;i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
