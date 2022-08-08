namespace LeetCode._876._Middle_of_the_Linked_List;

// https://leetcode.com/problems/middle-of-the-linked-list
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        var firstPointer = head;
        var secondPointer = head;

        while (secondPointer?.next is not null)
        {
            firstPointer = firstPointer.next!;
            secondPointer = secondPointer.next.next;
        }

        return firstPointer;
    }
}