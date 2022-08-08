namespace LeetCode._1337._The_K_Weakest_Rows_in_a_Matrix;

// https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/
public class Solution
{
    public int[] KWeakestRows(int[][] matrix, int k)
    {
        return matrix
            .Select((row, i) => new {Count = row.Count(c => c == 1), Index = i})
            .OrderBy(row => row.Count)
            .ThenBy(row => row.Index)
            .Select(row => row.Index)
            .Take(k)
            .ToArray();
    }
}