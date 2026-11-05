using DSA;
using DSA.Sorting;

int[] arr = [5, 1, 3, 5, 4, 7, 12, 9];

var res = CountingSort.Solution(arr);

foreach (var item in res)
{
    Console.WriteLine(item);
}