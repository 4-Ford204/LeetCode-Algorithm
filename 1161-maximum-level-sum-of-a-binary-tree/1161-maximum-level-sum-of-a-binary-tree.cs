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
    public List<int> Tree = new List<int>();

    public int MaxLevelSum(TreeNode root) {
        int result = 0, max = int.MinValue;

        DFS(root, 1);

        for (var i = 0; i < Tree.Count; i++) {
            if (max < Tree[i]) {
                max = Tree[i];
                result = i + 1;
            }
        }

        return result;
    }

    public void DFS(TreeNode node, int nodeLevel) {
        if (node == null) return;

        while (Tree.Count < nodeLevel) Tree.Add(0);

        Tree[nodeLevel++ - 1] += node.val;
        
        DFS(node.left, nodeLevel);
        DFS(node.right, nodeLevel);
    }
}