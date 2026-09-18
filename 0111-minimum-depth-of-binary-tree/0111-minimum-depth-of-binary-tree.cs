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
    public int MinDepth(TreeNode root) {
        return DFS(root);
    }

    private int DFS(TreeNode node) {
        if (node == null) return 0;

        var L = DFS(node.left);
        var R = DFS(node.right);

        return 1 + ((L == 0 || R == 0) ? Math.Max(L, R) : Math.Min(L, R));
    }
}