using System;
using System.Linq;
using System.Diagnostics;

public class Assertions
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        UseAssertToCheck(arr);

        var inputLength = arr.Length;
        var isSorted = true;

        if (isSorted)
        {
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }
        else
        {
            isSorted = false;
        }

        Debug.Assert(isSorted, "The given array isn't sorted correctly!");
        Debug.Assert(inputLength == arr.Length, "The input and output arrays are different!");
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        UseAssertToCheck(arr);

        CheckTheGivenIndexes(startIndex, endIndex);

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(minElementIndex > 0, "Invalid index!");

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        UseAssertToCheck(arr);

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        UseAssertToCheck(arr);

        CheckTheGivenIndexes(startIndex, endIndex);

        while (startIndex <= endIndex)
        {
            var isCorrectIndexes = startIndex <= endIndex;

            Debug.Assert(isCorrectIndexes, "Invalid operation!");

            int midIndex = (startIndex + endIndex) / 2;

            var invalidIndexes = (startIndex + endIndex) > 0;

            Debug.Assert(invalidIndexes, "Invalid indexes!");

            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        Debug.Assert(startIndex > endIndex, "Searching algorithm cannot work correctly!");

        // Searched value not found
        return -1;
    }

    public static void UseAssertToCheck<T>(T[] arr)
    {
        var inputLength = arr.Length;
        var isGreaterThanZero = inputLength > 0;
        var isWithNullValue = arr != null;

        Debug.Assert(isGreaterThanZero, "The input array is empty. It must be a valid array!S");
        Debug.Assert(isWithNullValue, "The input array cannot be null!");

    }

    public static void CheckTheGivenIndexes(int startIndex, int endIndex)
    {
        var isStartIndexGreaterThanZero = startIndex > 0;
        var isEndIndexGreaterThanZero = endIndex > 0;

        Debug.Assert(isStartIndexGreaterThanZero, "Invalid input for startIndex!");
        Debug.Assert(isEndIndexGreaterThanZero, "Invalid input for endIndex!");
    }
}
