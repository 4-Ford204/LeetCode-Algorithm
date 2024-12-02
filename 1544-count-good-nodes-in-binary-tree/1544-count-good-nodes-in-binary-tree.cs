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
    public int GoodNodes(TreeNode root) {
        return TraverseRecursively(root, -10001);
    }

    private int TraverseRecursively(TreeNode node, int max) {
        if (node == null)
            return 0;
        else {
            if (node.val >= max)
                return 1 + TraverseRecursively(node.left, node.val) + TraverseRecursively(node.right, node.val);
            else
                return TraverseRecursively(node.left, max) + TraverseRecursively(node.right, max); 
        }
    }
}