namespace LeetCode._1672._Richest_Customer_Wealth;

// https://leetcode.com/problems/richest-customer-wealth/
public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        return accounts
            .Select(account => account.Sum())
            .Max();
    }
}