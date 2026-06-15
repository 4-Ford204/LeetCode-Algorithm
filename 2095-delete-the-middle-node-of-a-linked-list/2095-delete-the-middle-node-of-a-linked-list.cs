/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteMiddle(ListNode head) {
        int count = 0;
        ListNode start = head, end = head.next;

        if (end == null) return end;
        if (end.next != null) end = end.next;

        while (end.next != null) {
            if (count % 2 == 0) start = start.next;
            end = end.next;
            count++;
        }

        start.next = start.next.next;
        
        return head;
    }
}