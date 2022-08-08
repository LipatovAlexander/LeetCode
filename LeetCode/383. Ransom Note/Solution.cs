namespace LeetCode._383._Ransom_Note;

// https://leetcode.com/problems/ransom-note
public class Solution
{
    public bool CanConstruct(string a, string b)
    {
        var dictA = CountNumberOfLetters(a);
        var dictB = CountNumberOfLetters(b);

        foreach (var c in dictA.Keys)
        {
            var inA = dictA[c];
            var inB = dictB.GetValueOrDefault(c, 0);

            if (inA > inB)
            {
                return false;
            }
        }

        return true;
    }

    private static Dictionary<char, int> CountNumberOfLetters(string str)
    {
        var dict = new Dictionary<char, int>();

        foreach (var c in str)
        {
            var prev = dict.GetValueOrDefault(c, 0);
            dict[c] = prev + 1;
        }

        return dict;
    }
}