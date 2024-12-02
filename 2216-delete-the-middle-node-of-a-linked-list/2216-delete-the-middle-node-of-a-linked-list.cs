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
        if (head.next == null)
            return null;
        else {
            int n = 1;
            int preMiddle = 0;
            var node = head;
            var preMiddleNode = head;

            while (node != null) {
                if (n / 2 > preMiddle + 1) {
                    preMiddle++;
                    preMiddleNode = preMiddleNode.next;
                }

                n++;
                node = node.next;
            }

            preMiddleNode.next = preMiddleNode.next.next;
            return head;
        }
    }
}