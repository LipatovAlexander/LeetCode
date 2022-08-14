namespace LeetCode._3._Longest_Substring_Without_Repeating_Characters;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var maxLength = 0;
        var startPosition = 0;
        var hashSet = new HashSet<char>();

        foreach (var next in s)
        {
            while (!hashSet.Add(next))
            {
                hashSet.Remove(s[startPosition]);
                startPosition++;
            }

            maxLength = Math.Max(maxLength, hashSet.Count);
        }

        return maxLength;
    }
}