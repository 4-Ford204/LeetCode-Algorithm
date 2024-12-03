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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        return root == null ? result : DFS(root, result);
    }

    private List<int> DFS(TreeNode node, List<int> result) {
        if (node.left != null) DFS(node.left, result);
        result.Add(node.val);
        if (node.right != null) DFS(node.right, result);

        return result;
    }
}