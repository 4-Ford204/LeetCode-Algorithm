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
    public int MaxLevelSum(TreeNode root) {
        Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
        int max = root.val;
        int trackingLevel = 1;
        var result = 1;
        queue.Enqueue((root, 1));

        while (queue.Count() > 0) {
            int sumLevel = 0;
            
            while (queue.Count() > 0 && queue.Peek().Item2 == trackingLevel) {
                TreeNode node = queue.Dequeue().Item1;
                sumLevel += node.val;

                if (node.left != null) queue.Enqueue((node.left, trackingLevel + 1));
                if (node.right != null) queue.Enqueue((node.right, trackingLevel + 1));
            }

            if (sumLevel > max) {
                max = sumLevel;
                result = trackingLevel;
            }

            trackingLevel++;
        }

        return result;
    }
}