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
    int LongestPath { get; set; } = 0;

    public int DiameterOfBinaryTree(TreeNode root) {
        DFS(root);
        return LongestPath;
    }

    private int DFS(TreeNode node) {
        if (node == null) return 0;

        int left = DFS(node.left);
        int right = DFS(node.right);
        LongestPath = Math.Max(LongestPath, left + right);

        return Math.Max(left, right) + 1;
    }
}