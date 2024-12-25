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
        Queue<TreeNode> queue = new Queue<TreeNode>();
        
        if (root == null) return list; 
        else queue.Enqueue(root);

        return BFS(list, queue);
    }

    private List<int> BFS(List<int> list, Queue<TreeNode> queue) {
        if (queue.Count == 0) return list;
        else {
            Queue<TreeNode> nextQueue = new Queue<TreeNode>();
            int max = queue.Peek().val;

            while (queue.Count > 0) {
                TreeNode node = queue.Dequeue();
                max = Math.Max(max, node.val);
                if (node.left != null) nextQueue.Enqueue(node.left);
                if (node.right != null) nextQueue.Enqueue(node.right);
            }

            list.Add(max);
            queue = nextQueue;

            return BFS(list, queue);
        }
    }
}