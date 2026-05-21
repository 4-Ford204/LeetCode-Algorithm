public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        int n = arr1.Length, m = arr2.Length, result = 0;
        var root = new TrieNode();
        var stack = new Stack<int>();

        for (var i = 0; i < n; i++) {
            var num = arr1[i];
            var current = root;

            while (num > 0) {
                stack.Push(num % 10);
                num /= 10;
            }

            while (stack.Count > 0) current = current.Update(stack.Pop());
        }

        for (int i = 0; i < m; i++) {
            int num = arr2[i], max = 0;
            var current = root;

            while (num > 0) {
                stack.Push(num % 10);
                num /= 10;
            }

            while (stack.Count > 0) {
                var next = current.Get(stack.Pop());

                if (next == null) stack.Clear();
                else {
                    current = next;
                    max++;
                }
            }

            result = Math.Max(result, max);
        }

        return result;
    }
}

public class TrieNode {
    private TrieNode[] arr;

    public TrieNode() {
        arr = new TrieNode[10];
    }

    public TrieNode Get(int digit) => arr[digit];

    public TrieNode Update(int digit) {
        if (arr[digit] == null) arr[digit] = new TrieNode();
        return arr[digit];
    }
}