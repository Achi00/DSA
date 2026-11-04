namespace DSA.Sorting
{
    public class MergeSort
    {
        public static int[] Solution(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums;
            }
            int middle = nums.Length / 2;

            var leftArr = new int[middle];
            var rightArr = new int[nums.Length - middle];

            Array.Copy(nums, 0, leftArr, 0, leftArr.Length);
            Array.Copy(nums, middle, rightArr, 0, rightArr.Length);

            var left = Solution(leftArr);
            var right = Solution(rightArr);

            return Merge(left, right);

        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];

            int l = 0;
            int r = 0;
            int i = 0;

            while (l < left.Length && r < right.Length)
            {
                if (left[l] <= right[r])
                {
                    result[i] = left[l];
                    l++;
                }
                else
                {
                    result[i] = right[r];
                    r++;
                }

                i++;
            }

            while (l < left.Length)
            {
                result[i] = left[l];
                i++;
                l++;
            }
            while (r < right.Length)
            {
                result[i] = right[r];
                i++;
                r++;
            }

            return result;
        }
    }
}
