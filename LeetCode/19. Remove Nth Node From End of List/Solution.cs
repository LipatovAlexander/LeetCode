namespace LeetCode._19._Remove_Nth_Node_From_End_of_List;

public class Solution
{
    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        var first = head;
        var second = head;

        for (var i = 0; i < n; i++)
        {
            second = second?.next;
        }

        while (second?.next is not null)
        {
            first = first.next!;
            second = second.next;
        }
        
        if (second is null)
        {
            return head.next;
        }
        
        first.next = first.next?.next;
        
        return head;
    }
}