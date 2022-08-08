namespace LeetCode.MiddleOfTheLinkedList;

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