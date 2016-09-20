namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public class HelperMethod
    {
        internal static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Validator.CheckForValidInputArray(arr);

            Validator.CheckTheGivenIndexes(arr, startIndex, endIndex);

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

        internal static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null || y != null, "Given value is null!");

            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
