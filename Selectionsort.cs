namespace DSA
{
    public static class Selectionsort
    {
        public static int[] Solution(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        var temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return nums;
        }
    }
}
