namespace LeetCode._283._Move_Zeroes;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        for (int i = 0, cur = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) continue;
            (nums[cur], nums[i]) = (nums[i], nums[cur]);
            cur++;
        }
    }
}