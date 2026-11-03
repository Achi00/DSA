namespace DSA
{
    public static class Selectionsort
    {
        public static int[] Solution(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int minIndx = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndx])
                    {
                        minIndx = j;
                    }
                }
                if (minIndx != i)
                {
                    var temp = nums[i];
                    nums[i] = nums[minIndx];
                    nums[minIndx] = temp;
                }
            }

            return nums;
        }
    }
}
