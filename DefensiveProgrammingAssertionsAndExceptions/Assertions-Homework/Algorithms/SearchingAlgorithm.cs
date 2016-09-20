namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public class SearchingAlgorithm
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Validator.CheckForValidInputArray(arr);

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Validator.CheckForValidInputArray(arr);

            Validator.CheckTheGivenIndexes(arr, startIndex, endIndex);

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
                    startIndex = midIndex + 1;
                }
                else
                {
                    endIndex = midIndex - 1;
                }
            }

            Debug.Assert(startIndex > endIndex, "Searching algorithm cannot work correctly!");

            return -1;
        }
    }
}
