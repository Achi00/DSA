namespace DSA.Search
{
    public class BinarySearch
    {
        public static int? Solution(int[] arr, int value)
        {
            int l = 0;
            int r = arr.Length - 1;

            while (l <= r)
            {
                // normal case
                //int m = (l + r) / 2;

                // overflow safe
                int m = l + (r - l) / 2;

                if (value == arr[m])
                {
                    return value;
                }

                // + 1 to avoid checking middle element again
                else if (arr[m] > value)
                {
                    r = m - 1;
                }
                else if (arr[m] < value)
                {
                    l = m + 1;
                }
            }

            return null;
        }
    }
}
