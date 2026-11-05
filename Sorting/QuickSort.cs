namespace DSA.Sorting
{
    // unsolved
    public class QuickSort
    {
        public static int[] Solution(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return arr;
            }
            var pivot = arr[^1];

            int j = 1;

            Sort(arr, 0, arr.Length - 1);

            return arr;
        }

        private static void Sort(int[] arr, int start, int end)
        {
            if (end <= start)
            {
                return;
            }
            int pivot = Partition(arr, start, end);

            Sort(arr, start, pivot - 1);
            Sort(arr, pivot + 1, end);
        }
        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];

            int i = start - 1;

            for (int j = start; j < end - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;

                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            i++;

            var temp1 = arr[i];
            arr[i] = arr[end];
            arr[end] = temp1;

            return i;
        }
    }
}
