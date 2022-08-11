namespace LeetCode._167._Two_Sum_II___Input_Array_Is_Sorted;

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        var sum = numbers[left] + numbers[right];
        while (sum != target)
        {
            if (sum > target)
                right--;
            else
                left++;
            sum = numbers[left] + numbers[right];
        }

        return new[] {left + 1, right + 1};
    }
}