using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listNumbers = { 10, 15, 20, 2, 4, 7, 65};
            PrintArray(listNumbers);
            BobbleS(listNumbers);
            PrintArray(listNumbers);

        }
        static void PrintArray(int[] arr)
        {
            foreach(int nums in arr)
            {
                Console.Write(nums + " ");
            }
            Console.WriteLine();
        }
        static void BobbleS(int[] arr)
        {
            for(int i =0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++) 
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            
        }
    }
}
