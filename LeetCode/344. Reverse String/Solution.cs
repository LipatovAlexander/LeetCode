namespace LeetCode._344._Reverse_String;

public class Solution
{
    public void ReverseString(char[] s)
    {
        for (var i = 0; i < s.Length / 2; i++)
        {
            (s[i], s[^(i + 1)]) = (s[^(i + 1)], s[i]);
        }
    }
}