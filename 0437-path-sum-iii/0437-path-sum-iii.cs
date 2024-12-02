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
    public int PathSum(TreeNode root, int targetSum) {
        int result = 0;
        var sumCacheFromRoot = new Dictionary<long, int>();
        sumCacheFromRoot[0] = 1;
        TraverseRecursively(root, 0);

        void TraverseRecursively(TreeNode node, long sum) {
            if (node != null) {
                sum += node.val;

                if (sumCacheFromRoot.TryGetValue(sum - targetSum, out int count))
                    result += count;

                sumCacheFromRoot.TryGetValue(sum, out int value);
                sumCacheFromRoot[sum] = ++value;
                
                TraverseRecursively(node.left, sum);
                TraverseRecursively(node.right, sum);

                sumCacheFromRoot[sum]--;
            }
        }

        return result;
    }
}