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
public class FindElements {
    private TreeNode Root { get; set; }
    private HashSet<int> Elements { get; set; }

    public FindElements(TreeNode root) {
        Root = root;
    }
    
    public bool Find(int target) {
        var depth = int.Log2(++target);
        var node = Root;
        var left = 1 << depth;
        var right = (1 << (depth + 1)) - 1;

        while (depth > 0 && node != null) {
            var middle = left + ((right - left) >> 1);

            if (middle >= target) {
                if (node.left == null) return false;
                right = middle;
                node = node.left;
            } else {
                if (node.right == null) return false;
                left = middle + 1;
                node = node.right;
            }

            depth--;
        }

        return true;
    }

    private void DFS(TreeNode node, int value) {
        Elements.Add(value);

        if (node.left != null) DFS(node.left, value * 2 + 1);
        if (node.right != null) DFS(node.right, value * 2 + 2);
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */