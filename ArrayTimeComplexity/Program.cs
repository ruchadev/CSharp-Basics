using System;

class Program
{
    static void Main(string[] args)
    {
        // Creation of Arrays
        int[] arr = new int[123];
        arr[0] = 1;

        char[] ch = new char[26];
        ch[0] = 't';

        bool[] b = new bool[223];
        b[0] = true;

        long[] num = new long[900];
        num[0] = 99999999;

        short[] snum = new short[888];
        snum[0] = 8888;

        Console.WriteLine("Array created successfully");

        // Array Addressing
        int[] sampleArray = new int[10];
        Console.WriteLine("Length of the array: " + sampleArray.Length);

        // Array Initialization
        int[] initializedArray = new int[] { 2, 3, 4, 5, 6 };
        int[] anotherArray = new int[5] { 1, 2, 3, 4, 5 };

        // Indexing in Array
        int[] indexedArray = new int[] { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine($"Element at index 5: {indexedArray[5]}");

        // Problem Statement: Sum of Array Elements
        int[] inputArray = new int[5];
        Console.WriteLine("Enter 5 integers:");
        for (int i = 0; i < 5; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            sum += inputArray[i];
        }
        Console.WriteLine($"Total sum of the array: {sum}");

        // Linear Search
        int[] searchArray = new int[] { 2, 4, 6, 8, 10 };
        Console.WriteLine("Enter the number to search:");
        int target = int.Parse(Console.ReadLine());

        bool found = false;
        for (int i = 0; i < searchArray.Length; i++)
        {
            if (searchArray[i] == target)
            {
                found = true;
                Console.WriteLine($"Target found at index {i}");
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Target not found");
        }

        // Function Call by Value and Reference
        int n = 5;
        ref int k = ref n;

        Console.WriteLine($"Before: {k}");
        k++;
        Console.WriteLine($"After: {n}");
        Console.WriteLine($"After: {k}");

        // Increment by Value
        Console.WriteLine("Enter a number:");
        n = int.Parse(Console.ReadLine());
        IncrementByOne(ref n);
        Console.WriteLine($"Incremented value: {n}");
    }

    static void IncrementByOne(ref int n)
    {
        n = n + 1;
    }
}