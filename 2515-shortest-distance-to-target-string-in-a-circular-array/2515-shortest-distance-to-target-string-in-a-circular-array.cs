public class Solution {
    public int ClosestTarget(string[] words, string target, int startIndex) {
        int n = words.Length, result = n;

        for (int i = 0; i < n; i++) {
            if (words[i].Equals(target)) {
                int j = Math.Abs(startIndex - i);
                result = Math.Min(result, Math.Min(j, n - j));
            }
        }

        return result < n ? result : -1;
    }
}