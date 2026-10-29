namespace DSA.Sorting
{
    public class MergeSort
    {
        public static void Solution(int[] nums)
        {
            int length = nums.Length;

            if (length <= 1)
            {
                return;
            }

            int middle = length / 2;

            int[] leftArr = new int[middle];
            int[] rightArr = new int[length - middle];

            int j = 0;

            for (int i = 0; i < length; i++)
            {
                if (i < middle)
                {
                    leftArr[i] = nums[i];
                }
                else
                {
                    rightArr[j] = nums[i];
                    j++;
                }
            }

            Solution(leftArr);
            Solution(rightArr);
            Merge(leftArr, rightArr, nums);
        }

        public static void Merge(int[] leftArr, int[] rightArr, int[] arr)
        {
            int left = arr.Length / 2;
            int right = arr.Length - left;

            int i = 0;
            int l = 0;
            int r = 0;

            while (l < left && r < right)
            {
                if (leftArr[l] < rightArr[r])
                {
                    arr[i] = leftArr[l];
                    i++;
                    l++;
                }
                else
                {
                    arr[i] = rightArr[r];
                    i++;
                    r++;
                }
            }

            while (l < left)
            {
                arr[i] = leftArr[l];
                i++;
                l++;
            }
            while (r < right)
            {
                arr[i] = rightArr[r];
                i++;
                r++;
            }
        }
    }
}
