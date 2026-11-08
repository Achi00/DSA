namespace DSA.TwoPointer
{
    public class IsPalindrome
    {
        public static bool Solution(string s)
        {
            if (s.Length <= 1)
            {
                return true;
            }
            int l = 0;
            int r = s.Length - 1;

            while (l < r)
            {
                if (s[l] != s[r])
                {
                    return false;
                }
                else
                {
                    l++;
                    r--;
                }
            }

            return true;
        }
    }
}
