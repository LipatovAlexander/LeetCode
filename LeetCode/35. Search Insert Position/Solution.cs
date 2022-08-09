namespace LeetCode._35._Search_Insert_Position;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        return SearchInsert(nums, target, 0, nums.Length);
    }

    private static int SearchInsert(int[] nums, int target, int left, int right)
    {
        if (left >= right - 1)
        {
            return target <= nums[left] ? left : right;
        }

        var middle = left + (right - left) / 2;
        return target < nums[middle]
            ? SearchInsert(nums, target, left, middle)
            : SearchInsert(nums, target, middle, right);
    }
}