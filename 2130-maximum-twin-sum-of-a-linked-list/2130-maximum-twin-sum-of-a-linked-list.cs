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
    public int PairSum(ListNode head) {
        ListNode slow = head, fast = head, previous = null, temp;
        while (fast != null) {
            fast = fast.next.next;
            temp = slow.next;
            slow.next = previous;
            previous = slow;
            slow = temp;
        }

        int max = slow.val + previous.val;
        while (slow != null) {
            max = Math.Max(max, slow.val + previous.val);
            
            slow = slow.next;
            previous = previous.next;
        }

        return max;
    }
}