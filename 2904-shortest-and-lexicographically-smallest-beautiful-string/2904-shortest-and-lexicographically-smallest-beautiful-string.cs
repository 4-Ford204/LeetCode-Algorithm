public class Solution {
    public string ShortestBeautifulSubstring(string s, int k) {
        int n = s.Length, count = 0;
        var result = s;

        if (s.Count(x => x == '1') < k) return string.Empty;

        for (int start = 0, end = 0; end < n; end++) {
            count += s[end] - '0';

            while (count > k || s[start] == '0')
                count -= s[start++] - '0';

            if (count == k) {
                var current = s.Substring(start, end - start + 1);

                if (
                    current.Length < result.Length ||
                    (
                        current.Length == result.Length &&
                        string.CompareOrdinal(current, result) < 0
                    )
                )
                    result = current;
            } 
        }

        return result;
    }
}