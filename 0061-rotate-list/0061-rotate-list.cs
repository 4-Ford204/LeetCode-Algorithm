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
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || head.next == null || k == 0) return head;

        int count = 1;
        var current = head;

        while (current.next != null) {
            count++;
            current = current.next;
        }

        k %= count;
        count -= k + 1;
        current.next = head;

        while (count-- > 0) head = head.next;

        current = head;
        head = head.next;
        current.next = null;

        return head;
    }
}