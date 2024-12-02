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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var leafs1 = new List<int>();
        var leafs2 = new List<int>();
        DFS(root1, leafs1);
        DFS(root2, leafs2);

        if (leafs1.Count != leafs2.Count) 
            return false;
        else {
            for (int i = 0; i < leafs1.Count; i++) {
                if (leafs1[i] != leafs2[i]) 
                    return false;
            }
        }
        
        return true;
    }

    private void DFS(TreeNode node, List<int> leafs) {
        if (node != null) {
            if (node.left == null && node.right == null) {
                leafs.Add(node.val);
            } else {
                DFS(node.left, leafs);
                DFS(node.right, leafs);
            }
        }
    }
}