namespace LeetCode._704._Binary_Search;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        return Search(nums, target, 0, nums.Length);
    }

    private int Search(int[] nums, int target, int left, int right)
    {
        if (left == right)
        {
            return -1;
        }

        if (left == right - 1)
        {
            return target == nums[left] ? left : -1;
        }

        var middle = (right + left) / 2;
        return target < nums[middle]
            ? Search(nums, target, left, middle)
            : Search(nums, target, middle, right);
    }
}