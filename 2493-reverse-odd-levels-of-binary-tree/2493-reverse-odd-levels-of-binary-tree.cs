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
    public TreeNode ReverseOddLevels(TreeNode root) {
        DFS(1, root.left, root.right);
        return root;
    }

    private void DFS(int level, TreeNode left, TreeNode right) {
        if (left == null || right == null) return;
        if (level % 2 == 1) (left.val, right.val) = (right.val, left.val);
        
        DFS(level + 1, left.left, right.right);
        DFS(level + 1, left.right, right.left);
    }
}