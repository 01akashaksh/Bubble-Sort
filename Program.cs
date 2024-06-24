using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 74,78483,903,928403,9292,9549,479324,434 };

        Console.WriteLine("Original list:");
        PrintList(numbers);

        BubbleSort(numbers);

        Console.WriteLine("Sorted list:");
        PrintList(numbers);
    }

    static void BubbleSort(List<int> list)
    {
        int n = list.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    // Swap list[j] and list[j + 1]
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }

    static void PrintList(List<int> list)
    {
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}