namespace DSA.TwoPointer
{
    public class ReverseArray
    {
        public static int[] Solution(int[] arr)
        {
            int l = 0;
            int r = arr.Length - 1;

            while (l < r)
            {
                var temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;
                l++;
                r--;
            }

            return arr;
        }
    }
}
