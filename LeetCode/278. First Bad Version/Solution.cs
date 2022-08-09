namespace LeetCode._278._First_Bad_Version;

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        return FirstBadVersion(1, n);
    }

    private int FirstBadVersion(int left, int right)
    {
        if (left >= right)
        {
            return left;
        }

        var middle = left + (right - left) / 2;
        return IsBadVersion(middle)
            ? FirstBadVersion(left, middle)
            : FirstBadVersion(middle + 1, right);
    }
}