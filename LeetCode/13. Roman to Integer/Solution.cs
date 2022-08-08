namespace LeetCode._13._Roman_to_Integer;

// https://leetcode.com/problems/roman-to-integer
public class Solution
{
    private static readonly Dictionary<char, int> RomanValues = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int RomanToInt(string s)
    {
        var result = 0;
        for (var i = 0; i < s.Length - 1; i++)
        {
            var current = RomanValues[s[i]];
            var next = RomanValues[s[i + 1]];
            if (current < next)
            {
                result -= current;
            }
            else
            {
                result += current;
            }
        }

        result += RomanValues[s.Last()];

        return result;
    }
}