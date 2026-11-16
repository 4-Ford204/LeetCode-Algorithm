public class Solution {
    public string DigitSum(string s, int k) {
        while (s.Length > k) {
            var group = new StringBuilder();

            for (int i = 0; i < s.Length; i += k) {
                int sum = 0;
                int end = Math.Min(i + k, s.Length);

                for (int j = i; j < end; j++) sum += s[j] - '0';

                group.Append(sum);
            }

            s = group.ToString();
        }

        return s;
    }
}