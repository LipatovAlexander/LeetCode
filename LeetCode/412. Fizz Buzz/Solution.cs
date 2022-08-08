using System.Text;

namespace LeetCode._412._Fizz_Buzz;

// https://leetcode.com/problems/fizz-buzz
public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        const string fizz = "Fizz";
        const string buzz = "Buzz";

        var answer = new string[n];

        for (var i = 1; i <= n; i++)
        {
            var sb = new StringBuilder();
            if (i % 3 == 0)
            {
                sb.Append(fizz);
            }

            if (i % 5 == 0)
            {
                sb.Append(buzz);
            }

            if (i % 3 != 0 && i % 5 != 0)
            {
                sb.Append(i);
            }

            answer[i - 1] = sb.ToString();
        }

        return answer;
    }
}