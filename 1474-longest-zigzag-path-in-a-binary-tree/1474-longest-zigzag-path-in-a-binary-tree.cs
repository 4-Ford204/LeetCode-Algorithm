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
    private int PathLength { get; set; } = 0;

    public int LongestZigZag(TreeNode root) {
        PathLength = 0;
        DFS(root.left, true, 1); 
        DFS(root.right, false, 1);
        
        return PathLength;
    }

    private void DFS(TreeNode node, bool direction, int steps) {
        if (node == null) return;
        else {
            PathLength = Math.Max(PathLength, steps);

            if (!direction) {
                DFS(node.left, true, steps + 1);
                DFS(node.right, false, 1);
            } else {
                DFS(node.left, true, 1);
                DFS(node.right, false, steps + 1);
            }
        }
    }
}