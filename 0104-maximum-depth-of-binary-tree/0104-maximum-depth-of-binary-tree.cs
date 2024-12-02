/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        return TraverseRecursively(root);
    }

    private int TraverseRecursively(TreeNode node) {
        if (node == null) return 0;
        else {
            int leftTracking = TraverseRecursively(node.left);
            int rightTracking = TraverseRecursively(node.right);
            
            return Math.Max(leftTracking, rightTracking) + 1;
        }
    }
}