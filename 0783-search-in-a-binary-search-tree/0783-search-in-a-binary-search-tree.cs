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
    public TreeNode SearchBST(TreeNode root, int val) {
        return DFS(root, val);
    }

    private TreeNode BFS(TreeNode root, int val) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count() > 0) {
            var node = queue.Dequeue();

            if (node.val == val) return node;
            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
        }

        return null;
    }

    private TreeNode DFS(TreeNode root, int val) {
        if (root == null) return null;
        else if (root.val < val) return DFS(root.right, val);
        else if (root.val > val) return DFS(root.left, val);
        else return root;
    }
}