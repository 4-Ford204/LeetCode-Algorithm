public class Solution {
    public int LongestBalanced(string s) {
        int n = s.Length, result = int.MinValue;

        for (int i = 0; i < n; i++) {
            var freq = new int['z' - 'a' + 1];
            
            for (int j = i; j < n; j++) {
                freq[s[j] - 'a']++;
                int count = 0;

                foreach (var value in freq) {
                    if (value != 0) {
                        if (count == 0) count = value;
                        else if (count != value) {
                            count = 0;
                            break;
                        }
                    }
                }

                if (count != 0) result = Math.Max(result, j - i + 1);
            }
        }

        return result;
    }
}