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
    public ListNode ReverseList(ListNode head) {
        return ReverseListRecursively(head, null);
    }

    private ListNode ReverseListIteratively(ListNode head) {
        ListNode preNode = null;
        ListNode node = head;

        while (node != null) {
            var nextNode = node.next;
            node.next = preNode;
            preNode = node;
            node = nextNode;
        }

        return preNode;
    }

    private ListNode ReverseListRecursively(ListNode node, ListNode preNode) {
        if (node == null) {
            return preNode;
        } else {
            var nextNode = node.next;
            node.next = preNode;
            
            return ReverseListRecursively(nextNode, node);
        }
    }
}