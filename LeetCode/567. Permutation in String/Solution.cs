namespace LeetCode._567._Permutation_in_String;

public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        var f1 = GetFrequencies(s1);
        var f2 = GetFrequencies(s2[..s1.Length]);

        for (int i = 0, j = s1.Length; j < s2.Length; i++, j++)
        {
            if (FrequenciesEquals(f1, f2))
            {
                return true;
            }

            Decrement(f2, s2[i]);
            Increment(f2, s2[j]);
        }

        return FrequenciesEquals(f1, f2);
    }

    private static bool FrequenciesEquals(IReadOnlyDictionary<char, int> first, IReadOnlyDictionary<char, int> second)
    {
        return first.Keys.All(key => first[key] == second.GetValueOrDefault(key));
    }

    private static Dictionary<char, int> GetFrequencies(string str)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in str)
        {
            Increment(dict, c);
        }

        return dict;
    }

    private static void Increment(Dictionary<char, int> dict, char key)
    {
        dict[key] = dict.GetValueOrDefault(key) + 1;
    }

    private static void Decrement(Dictionary<char, int> dict, char key)
    {
        dict[key] = dict.GetValueOrDefault(key) - 1;
    }
}