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
    public ListNode OddEvenList(ListNode head) {
        if (head == null || head.next == null) 
            return head;

        ListNode oddHead = head;
        ListNode evenHead = head.next;
        ListNode oddTracking = oddHead;
        ListNode evenTracking = evenHead;

        while (evenTracking != null && evenTracking.next != null) {
            oddTracking.next = oddTracking.next.next;
            evenTracking.next = evenTracking.next.next;
            oddTracking = oddTracking.next;
            evenTracking = evenTracking.next;
        }
        oddTracking.next = evenHead;
        
        return head;
    }
}