namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public class SortingAlgorithm
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Validator.CheckForValidInputArray(arr);

            var inputLength = arr.Length;
            var isSorted = true;

            if (isSorted)
            {
                for (int index = 0; index < arr.Length - 1; index++)
                {
                    int minElementIndex = HelperMethod.FindMinElementIndex(arr, index, arr.Length - 1);
                    HelperMethod.Swap(ref arr[index], ref arr[minElementIndex]);
                }
            }
            else
            {
                isSorted = false;
            }

            Debug.Assert(isSorted, "The given array isn't sorted correctly!");
            Debug.Assert(inputLength == arr.Length, "The input and output arrays are different!");
        }
    }
}
