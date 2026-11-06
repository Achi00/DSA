namespace DSA
{
    public static class Selectionsort
    {
        public static int[] Solution(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        minIndex = j;
                        var temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            return nums;
        }
    }
}
