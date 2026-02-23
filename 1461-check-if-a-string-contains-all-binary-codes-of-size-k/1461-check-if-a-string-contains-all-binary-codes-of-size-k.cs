public class Solution {
    public bool HasAllCodes(string s, int k) {
        if (s.Length < k) return false;

        int num = 0, max = 1 << k, count = 0;
        var seen = new bool[max];

        for (var i = 0; i < s.Length; i++) {
            num = ((num << 1) & (max - 1)) | (s[i] - '0');
            
            if (i >= k - 1) {
                if (!seen[num]) {
                    seen[num] = true;
                    if (++count == max) return true;
                }
            }
        }

        return count == max;
    }
}