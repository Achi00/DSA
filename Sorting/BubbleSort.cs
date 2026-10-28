namespace DSA.Sorting
{
    public class BubbleSort
    {
        public static int[] Solution(int[] nums)
        {
            bool changed = true;


            while (changed)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            var temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                        else
                        {
                            changed = false;
                        }
                    }
                }
            }

            return nums;
        }
    }
}
