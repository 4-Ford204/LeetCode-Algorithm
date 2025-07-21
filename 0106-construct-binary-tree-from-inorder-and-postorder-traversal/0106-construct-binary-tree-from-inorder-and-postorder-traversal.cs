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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        return Recursion(inorder, postorder);
    }

    private TreeNode? Recursion(Span<int> inorder, Span<int> postorder) {
        if (inorder.IsEmpty || postorder.IsEmpty) return null;

        var position = inorder.IndexOf(postorder[^1]);
        var left = Recursion(inorder[..position], postorder[..position]);
        var right = Recursion(inorder[(position + 1)..], postorder[position..^1]);

        return new TreeNode(postorder[^1], left, right);
    }
}