public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {
        int n = s.Length, count = 0;
        var dp = new bool[n];
        dp[0] = true;

        if (s[n - 1] != '0') return false;

        for (int i = 1; i < n; i++) {
            if (i >= minJump && dp[i - minJump]) count++;
            if (i > maxJump && dp[i - maxJump - 1]) count--;
            if (s[i] == '0' && count > 0) dp[i] = true;
        }

        return dp[n - 1];
    }
}