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
    public TreeNode LcaDeepestLeaves(TreeNode root) {
        return PostOrderTraversal(root).Node;
    }

    private (TreeNode Node, int Value) PostOrderTraversal(TreeNode node) {
        if (node == null) return (null, 0);

        var left = PostOrderTraversal(node.left);
        var right = PostOrderTraversal(node.right);

        return 
            (left.Value > right.Value) ? (left.Node, left.Value + 1) :
            (left.Value < right.Value) ? (right.Node, right.Value + 1) :
            (node, left.Value + 1);
    }
}