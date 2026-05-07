public class Solution {
    public int[] MaxValue(int[] nums) {
        int n = nums.Length;
        var ans = new int[n];
        var stack = new List<(int Value, int Left, int Right)>();

        for (int i = 0; i < n; i++) {
            var current = (Value: nums[i], Left: i, Right: i);

            while (stack.Count > 0 && stack[^1].Value > nums[i]) {
                var top = stack[^1];
                stack.RemoveAt(stack.Count - 1);
                current = (Math.Max(current.Value, top.Value), top.Left, current.Right);
            }

            stack.Add(current);
        }

        for (int i = 0; i < stack.Count; i++) {
            for (int j = stack[i].Left; j <= stack[i].Right; j++)
                ans[j] = stack[i].Value;
        }

        return ans;
    }
}