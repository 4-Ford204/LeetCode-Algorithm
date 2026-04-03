public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length, result = 0;
        var stack = new Stack<int>();
        var arr = new int[n + 1];

        Array.Copy(heights, arr, n);
        arr[n] = 0;

        for (int i = 0; i <= n; i++) {
            while (stack.Count > 0 && arr[i] < arr[stack.Peek()])
                result = Math.Max(
                    result,
                    arr[stack.Pop()] * (stack.Count == 0 ? i : i - stack.Peek() - 1)
                );

            stack.Push(i);
        }

        return result;
    }
}