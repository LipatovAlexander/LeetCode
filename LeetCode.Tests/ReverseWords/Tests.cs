using FluentAssertions;
using LeetCode._557._Reverse_Words_in_a_String_III;

namespace LeetCode.Tests.ReverseWords;

public class Tests
{
    [Fact]
    public void Test()
    {
        var solution = new Solution();
        const string str = "fuck you";
        var result = solution.ReverseWords(str);

        result.Should().Be("kcuf uoy");
    }
}