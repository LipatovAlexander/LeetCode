namespace LeetCode._189._Rotate_Array;

public class Solution
{
    public void RotateReverse(int[] nums, int k)
    {
        k %= nums.Length;

        Reverse(nums, 0, nums.Length - 1);

        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    private void Reverse(int[] nums, int start, int end)
    {
        var length = end - start + 1;
        var steps = length / 2;

        for (var i = 0; i < steps; i++)
        {
            (nums[start + i], nums[end - i]) = (nums[end - i], nums[start + i]);
        }
    }

    // Time - O(2n), Memory - O(n)
    public void RotateWithExtraSpace(int[] nums, int k)
    {
        k %= nums.Length;

        var arr = new int[k];

        for (var i = 0; i < k; i++)
        {
            arr[i] = nums[nums.Length - k + i];
        }

        for (var i = nums.Length - 1; i >= k; i--)
        {
            nums[i] = nums[i - k];
        }

        for (var i = 0; i < k; i++)
        {
            nums[i] = arr[i];
        }
    }
}