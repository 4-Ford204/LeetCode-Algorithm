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
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        return DFS(root).Node;
    }

    private (TreeNode Node, int Depth) DFS(TreeNode node) {
        if (node == null) return (null, 0);

        var L = DFS(node.left);
        var R = DFS(node.right);

        if (L.Depth > R.Depth) return (L.Node, L.Depth + 1);
        if (R.Depth > L.Depth) return (R.Node, R.Depth + 1);

        return (node, L.Depth + 1);
    }
}
