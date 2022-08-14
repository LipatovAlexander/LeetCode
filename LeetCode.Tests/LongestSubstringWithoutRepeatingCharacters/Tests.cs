using FluentAssertions;
using LeetCode._3._Longest_Substring_Without_Repeating_Characters;

namespace LeetCode.Tests.LongestSubstringWithoutRepeatingCharacters;

public class Tests
{
    [Theory]
    [InlineData("uqinntq", 4)]
    public void SimpleTest(string input, int expected)
    {
        var solution = new Solution();
        var result = solution.LengthOfLongestSubstring(input);

        result.Should().Be(expected);
    }
}