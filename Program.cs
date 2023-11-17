using System;

class SortingAndSearching
{
    static void Main()
    {
        // Example usage:
        int[] randomArray = { 50, 79, 68, 52, 12, 32, 14 };

        Console.WriteLine("Original Array:");
        PrintArray(randomArray);

        BubbleSort(randomArray);

        Console.WriteLine("\nSorted Array:");
        PrintArray(randomArray);

        Console.Write("\nEnter a number to search: ");
        int target = int.Parse(Console.ReadLine());

        int index = BinarySearch(randomArray, target);

        if (index != -1)
            Console.WriteLine($"Element {target} found at index {index}.");
        else
            Console.WriteLine($"Element {target} not found in the array.");
        Console.ReadKey();
    }

    // Bubble Sort implementation
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    // swap arr[j+1] and arr[j]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Method to generate a random array of integers
    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(1, 100); // Adjust the range as needed
        }
        return arr;
    }

    // Method to check if an array is sorted
    static bool IsSorted(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
                return false;
        }
        return true;
    }

    // Binary Search implementation
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1; // Element not found
    }

    // Method to print an array
    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
