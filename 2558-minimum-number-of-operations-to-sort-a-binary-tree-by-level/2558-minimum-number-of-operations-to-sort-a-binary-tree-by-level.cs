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
    public int MinimumOperations(TreeNode root) {
        int[] values = new int[50_000];
        TreeNode[] nodes = new TreeNode[50_000];
        TreeNode[] nextNodes = new TreeNode[50_000];  
        int result = 0, length = 0, nextLength = 0;
        nodes[length++] = root;

        while (length > 0) {
            for (int i = 0; i < length; values[i] = i++);
            Array.Sort(values, 0, length, Comparer<int>.Create((x, y) => nodes[x].val - nodes[y].val));

            for (int i = 0; i < length; i++) {
                TreeNode node = nodes[i];

                if (node.left != null) nextNodes[nextLength++] = node.left;
                if (node.right != null) nextNodes[nextLength++] = node.right;
                if (values[i] == i) continue;
                else {
                    for (int j = i; values[j] != j; (j, values[j]) = (values[j], j), result++);
                    result--;
                }
            }

            (nodes, nextNodes) = (nextNodes, nodes);
            (length, nextLength) = (nextLength, 0);
        }

        return result;
    }
}