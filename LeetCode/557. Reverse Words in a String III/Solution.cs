namespace LeetCode._557._Reverse_Words_in_a_String_III;

public class Solution
{
    public string ReverseWords(string s)
    {
        return new string(ReverseWords(s.ToCharArray()));
    }

    private static char[] ReverseWords(char[] s)
    {
        var start = 0;

        for (var end = 0; end < s.Length; end++)
        {
            if (char.IsWhiteSpace(s[end]))
            {
                Reverse(s, start, end - 1);
                end++;
                start = end;
            }
            else if (end == s.Length - 1)
            {
                Reverse(s, start, end);
            }
        }

        return s;
    }

    private static void Reverse(IList<char> s, int start, int end)
    {
        var length = end - start + 1;
        var steps = length / 2;
        for (var i = 0; i < steps; i++)
        {
            (s[start + i], s[end - i]) = (s[end - i], s[start + i]);
        }
    }
}