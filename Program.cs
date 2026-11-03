using DSA.Sorting;

int[] arr = [5, 1, 3, 4, 7, 12, 9];

InsertionSort.Solution(arr);

foreach (var item in arr)
{
    Console.WriteLine(item);
}