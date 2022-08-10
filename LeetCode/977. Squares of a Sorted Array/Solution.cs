namespace LeetCode._977._Squares_of_a_Sorted_Array;

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        var absMinIndex = FindAbsMinIndex(nums);
        var result = new List<int>
        {
            nums[absMinIndex] * nums[absMinIndex]
        };

        var left = absMinIndex - 1;
        var right = absMinIndex + 1;

        while (left >= 0 && right < nums.Length)
        {
            var leftNum = nums[left];
            var rightNum = nums[right];

            if (Math.Abs(leftNum) < Math.Abs(rightNum))
            {
                result.Add(leftNum * leftNum);
                left--;
            }
            else
            {
                result.Add(rightNum * rightNum);
                right++;
            }
        }

        while (left >= 0)
        {
            result.Add(nums[left] * nums[left]);
            left--;
        }

        while (right < nums.Length)
        {
            result.Add(nums[right] * nums[right]);
            right++;
        }

        return result.ToArray();
    }

    private int FindAbsMinIndex(int[] nums)
    {
        var i = 0;
        while (i < nums.Length - 1 && Math.Abs(nums[i]) >= Math.Abs(nums[i + 1]))
        {
            i++;
        }

        return i;
    }
}