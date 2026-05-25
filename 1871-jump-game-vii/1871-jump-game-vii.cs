public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {
        int n = s.Length;
        int[] prefix = new int[n], arr = new int[n];
        arr[0] = 1;

        if (s[n - 1] != '0') return false;

        for (int i = 0; i < minJump; i++) prefix[i] = 1;

        for (int i = minJump; i < n; i++) {
            int start = i - maxJump, end = i - minJump;

            if (s[i] == '0') {
                int sum = prefix[end] - (start <= 0 ? 0 : prefix[start - 1]);
                arr[i] = sum != 0 ? 1 : 0;
            }

            prefix[i] = prefix[i - 1] + arr[i];
        }

        return arr[n - 1] == 1;
    }
}