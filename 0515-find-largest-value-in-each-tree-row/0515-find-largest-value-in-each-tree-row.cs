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
    public IList<int> LargestValues(TreeNode root) {
        List<int> list = new List<int>();
        DFS(root, 0, list);

        return list;
    }

    private void DFS(TreeNode node, int level, List<int> list) {
        if (node == null) return;
        else {
            if (level == list.Count) list.Add(node.val);
            else list[level] = Math.Max(list[level], node.val);

            DFS(node.left, level + 1, list);
            DFS(node.right, level + 1, list);
        }
    }
}