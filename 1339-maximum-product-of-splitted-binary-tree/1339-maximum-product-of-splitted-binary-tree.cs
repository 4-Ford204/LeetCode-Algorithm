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
    private long Total = 0;
    private long Result = 0;

    public int MaxProduct(TreeNode root) {
        Total = TreeTotal(root);
        SubTreeTotal(root);
        return (int)(Result % 1_000_000_007);
    }

    private long TreeTotal(TreeNode node) {
        if (node == null) return 0;
        return node.val + TreeTotal(node.left) + TreeTotal(node.right);
    }

    private long SubTreeTotal(TreeNode node) {
        if (node == null) return 0;

        long left = SubTreeTotal(node.left);
        long right = SubTreeTotal(node.right);
        long subTreeTotal = node.val + left + right;

        if (left > 0) Result = Math.Max(Result, left * (Total - left));
        if (right > 0) Result = Math.Max(Result, right * (Total - right));
        
        return subTreeTotal;
    }
}