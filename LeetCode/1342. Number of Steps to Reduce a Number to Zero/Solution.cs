namespace LeetCode._1342._Number_of_Steps_to_Reduce_a_Number_to_Zero;

// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
public class Solution
{
    public int NumberOfSteps(int num)
    {
        var steps = 0;
        while (num is not 0)
        {
            num = num % 2 == 0 ? num / 2 : num - 1;
            steps++;
        }

        return steps;
    }
}