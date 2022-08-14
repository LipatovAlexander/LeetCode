using FluentAssertions;
using LeetCode._567._Permutation_in_String;

namespace LeetCode.Tests.PermutationInString;

public class Tests
{
    [Fact]
    public void Test()
    {
        var solution = new Solution();
        var s1 = "adc";
        var s2 = "dcda";
        var result = solution.CheckInclusion(s1, s2);
        result.Should().BeTrue();
    }
}