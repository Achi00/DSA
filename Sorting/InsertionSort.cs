namespace DSA.Sorting
{
    public static class InsertionSort
    {
        public static int[] Solution(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (nums[j - 1] > nums[i])
                    {
                        var temp = nums[j - 1];
                        nums[j - 1] = nums[i];
                        nums[i] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return nums;
        }
    }
}
