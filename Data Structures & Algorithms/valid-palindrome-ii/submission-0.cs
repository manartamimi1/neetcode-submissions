public class Solution
{
    public bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public bool ValidPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] == s[right])
            {
                left++;
                right--;
            }
            else
            {
                // Try skipping either the left character or the right character
                return IsPalindrome(s, left + 1, right) ||
                       IsPalindrome(s, left, right - 1);
            }
        }

        return true;
    }
}