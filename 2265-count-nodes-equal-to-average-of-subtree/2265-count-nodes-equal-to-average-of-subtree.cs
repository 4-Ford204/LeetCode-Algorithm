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
    public int AverageOfSubtree(TreeNode root) {
        int result = 0;
        
        DFS(root, ref result);

        return result;
    }

    private int[] DFS(TreeNode node, ref int result) {
        if (node == null) return new int[] { 0, 0 };

        var L = DFS(node.left, ref result);
        var R = DFS(node.right, ref result);

        var sum = L[0] + R[0] + node.val;
        var count = L[1] + R[1] + 1;

        if (node.val == sum / count) result++;

        return new int[] { sum, count };
    }
}