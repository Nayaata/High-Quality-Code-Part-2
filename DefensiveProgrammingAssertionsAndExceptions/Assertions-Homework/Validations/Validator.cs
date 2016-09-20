namespace Assertions_Homework
{
    using System.Diagnostics;

    public class Validator
    {
        public static void CheckForValidInputArray<T>(T[] arr)
        {
            var inputLength = arr.Length;
            var isGreaterThanZero = inputLength > 0;
            var isWithNullValue = arr != null;

            Debug.Assert(isGreaterThanZero, "The input array is empty. It must be a valid array!S");
            Debug.Assert(isWithNullValue, "The input array cannot be null!");

        }

        public static void CheckTheGivenIndexes<T>(T[] arr, int startIndex, int endIndex)
        {
            var length = arr.Length;

            var isStartIndexGreaterThanZero = startIndex > 0;
            var isEndIndexGreaterThanZero = endIndex > 0;

            var isValidStartIndex = startIndex <= length - 1;
            var isValidEndIndex = endIndex <= length - 1;

            Debug.Assert(isStartIndexGreaterThanZero && isValidStartIndex, "Invalid input for startIndex!");
            Debug.Assert(isEndIndexGreaterThanZero && isValidEndIndex, "Invalid input for endIndex!");
        }
    }
}
