using System;

class SearchingandSorting
{
    static void Main(string[] arg)
    {
        // Example for finding the peak element
        int[] arr = new int[] { 10, 50, 20, 60, 80 };
        int n = arr.Length;

        int peakIndex = Peekelement(arr, n);

        if (peakIndex == -1)
        {
            Console.WriteLine("Element not found");
        }
        else
        {
            Console.WriteLine($"Peak element found at index: {peakIndex}");
        }

        // Example for binary search
        int[] sortedArr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        int target = 90;
        int binarySearchIndex = BinarySearch(sortedArr, sortedArr.Length, target);

        if (binarySearchIndex == -1)
        {
            Console.WriteLine("Element not found in binary search");
        }
        else
        {
            Console.WriteLine($"Element found at index: {binarySearchIndex}");
        }

        // Example for finding the first occurrence of a number
        int firstOccurrenceIndex = SearchFirstOccurrence(sortedArr, sortedArr.Length, target);
        if (firstOccurrenceIndex == -1)
        {
            Console.WriteLine("First occurrence not found");
        }
        else
        {
            Console.WriteLine($"First occurrence found at index: {firstOccurrenceIndex}");
        }

        // Example for finding the last occurrence of a number
        int lastOccurrenceIndex = SearchLastOccurrence(sortedArr, sortedArr.Length, target);
        if (lastOccurrenceIndex == -1)
        {
            Console.WriteLine("Last occurrence not found");
        }
        else
        {
            Console.WriteLine($"Last occurrence found at index: {lastOccurrenceIndex}");
        }
    }

    // Binary Search
    static int BinarySearch(int[] arr, int n, int target)
    {
        int start = 0;
        int end = n - 1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (target > arr[mid])
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return -1; // Element not found
    }

    // Find the first occurrence of a number in a sorted array
    static int SearchFirstOccurrence(int[] arr, int n, int target)
    {
        int start = 0;
        int end = n - 1;
        int ans = -1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (arr[mid] == target)
            {
                ans = mid;
                end = mid - 1; // Move left to find the first occurrence
            }
            else if (target > arr[mid])
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return ans;
    }

    // Find the last occurrence of a number in a sorted array
    static int SearchLastOccurrence(int[] arr, int n, int target)
    {
        int start = 0;
        int end = n - 1;
        int ans = -1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (arr[mid] == target)
            {
                ans = mid;
                start = mid + 1; // Move right to find the last occurrence
            }
            else if (target > arr[mid])
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return ans;
    }

    // Find the peak element in a mountain array
    static int Peekelement(int[] arr, int n)
    {
        int start = 0;
        int end = n - 1;

        while (start < end)
        {
            int mid = start + (end - start) / 2;

            if (arr[mid] < arr[mid + 1])
            {
                start = mid + 1;
            }
            else
            {
                end = mid;
            }
        }

        return start; // `start` will point to the peak element
    }
}