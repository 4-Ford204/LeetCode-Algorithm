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
    private List<int> RightSide { get; set; }
    private int Depth { get; set; }

    public IList<int> RightSideView(TreeNode root) {
        RightSide = new List<int>();
        Depth = 0;
        DFS(root, 1);

        return RightSide;
    }

    private void DFS(TreeNode node, int depth) {
        if (node == null) return;
        else {
            if (depth == Depth + 1) {
                RightSide.Add(node.val);
                Depth++;
            }
            
            DFS(node.right, depth + 1);
            DFS(node.left, depth + 1);
        }
    }
}