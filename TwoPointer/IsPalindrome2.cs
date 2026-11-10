namespace DSA.TwoPointer
{
    public class IsPalindrome2
    {
        public static bool Solution(string s)
        {
            int l = 0;
            int r = s.Length - 1;

            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                }
                else
                {
                    return Check(s, l + 1, r) || Check(s, l, r - 1);
                }
            }

            return true;
        }

        private static bool Check(string s, int l, int r)
        {
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
