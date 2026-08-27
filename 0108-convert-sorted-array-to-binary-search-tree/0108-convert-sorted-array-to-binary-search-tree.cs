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
    public TreeNode SortedArrayToBST(int[] nums) {
        return nums.Length == 0 ?
            null :
            new TreeNode(
                nums[nums.Length / 2],
                SortedArrayToBST(nums[..(nums.Length / 2)]),
                SortedArrayToBST(nums[(nums.Length / 2 + 1)..])
            );
    }
}