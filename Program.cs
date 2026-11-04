using DSA;
using DSA.Sorting;

int[] arr = [5, 1, 3, 4, 7, 12, 9];

var res = MergeSort.Solution(arr);

foreach (var item in res)
{
    Console.WriteLine(item);
}