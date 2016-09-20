namespace Assertions_Homework
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Validator.CheckForValidInputArray(arr);

            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SortingAlgorithm.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SortingAlgorithm.SelectionSort(new int[0]); 
            SortingAlgorithm.SelectionSort(new int[1]); 

            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, -1000));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 0));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 17));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 10));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 1000));
        }
    }
}
