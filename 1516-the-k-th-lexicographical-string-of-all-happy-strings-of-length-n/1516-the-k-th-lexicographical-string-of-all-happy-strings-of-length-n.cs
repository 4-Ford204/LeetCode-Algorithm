public class Solution {
    public string GetHappyString(int n, int k) {
        var total = 3 * (1 << (n - 1));
        var current = 0;
        var builder = new StringBuilder();

        if (k > total) return string.Empty;

        for (int i = 0; i < 3; i++) {
            if (current + (1 << (n - 1)) >= k) {
                builder.Append((char)('a' + i));
                break;
            }

            current += 1 << (n - 1);
        }

        for (int i = 1; i < n; i++) {
            if (current + (1 << (n - i - 1)) >= k)
                builder.Append(builder[^1] == 'a' ? 'b' : 'a');
            else {
                builder.Append(builder[^1] == 'c' ? 'b' : 'c');
                current += 1 << (n - i - 1);
            }
        }

        return builder.ToString();
    }

    private StringBuilder Backtracking(StringBuilder current, List<StringBuilder> happyList, int n, int k) {
        int length = current.Length;

        if (length == n) {
            if (happyList.Count == k - 1) return current;
            else happyList.Add(current);
        } else {
            for (var i = 'a'; i <= 'c'; i++) {
                if (length == 0 || current[length - 1] != i) {
                    current.Append(i);
                    var result = Backtracking(current, happyList, n, k);
                    if (result.Length > 0) return result;
                    current.Length--;
                }
            }
        }

        return new StringBuilder();
    }
}