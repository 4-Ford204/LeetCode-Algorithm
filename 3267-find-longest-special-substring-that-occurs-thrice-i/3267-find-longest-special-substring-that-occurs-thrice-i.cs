public class Solution {
    public int MaximumLength(string s) {
        int n = s.Length, left = 1, right = n - 1;

        while (left <= right) {
            int middle = left + (right - left) / 2;
            int[] frequency = new int[26];
            bool isMatchMiddle = false;

            for (int i = 0; i < n;) {
                int next = i + 1;
                int current = s[i] - 'a';

                while (next < n && s[next] == s[i]) next++;

                frequency[current] += Math.Max(0, next - i - middle + 1);

                if (frequency[current] >= 3) isMatchMiddle = true;

                i = next;
            }

            if (isMatchMiddle) left = middle + 1; 
            else right = middle - 1;
        }

        return right == 0 ? -1 : right;
    }
}