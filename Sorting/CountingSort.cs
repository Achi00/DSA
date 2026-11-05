namespace DSA.Sorting
{
    public class CountingSort
    {
        public static int[] Solution(int[] nums)
        {
            int max = nums.Max();

            var arr = new int[max + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                arr[nums[i]]++;
            }

            int k = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == 0)
                {
                    continue;
                }
                else
                {
                    while (arr[j] != 0)
                    {
                        arr[j]--;
                        nums[k] = j;
                        k++;
                    }
                }
            }
            return nums;
        }
    }
}
