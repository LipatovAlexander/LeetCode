using FluentAssertions;
using LeetCode._13._Roman_to_Integer;

namespace LeetCode.Tests.RomanToInteger;

public class Tests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void Test(string input, int expected)
    {
        var solution = new Solution();
        var result = solution.RomanToInt(input);
        result.Should().Be(expected);
    }
}