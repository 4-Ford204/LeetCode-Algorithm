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
    public int SumRootToLeaf(TreeNode root) {
        return DFS(root, 0);
    }
       
    public int DFS(TreeNode node, int num) {
        if (node == null) return 0;

        num = (num << 1) | node.val;
        var sum = DFS(node.left, num) + DFS(node.right, num);

        return sum == 0 ? num : sum;
    }
}