using DSA;
using DSA.Search;
using DSA.Sorting;

int[] arr = [5, 1, 3, 5, 4, 7, 12, 9];

var res = BinarySearch.Solution(arr, 5);

if (res is not null)
{
    Console.WriteLine(res);
}