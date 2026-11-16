public class Solution {
    public string DigitSum(string s, int k) {
        while (s.Length > k) {
            var group = new StringBuilder();

            for (int i = 0; i < s.Length; i += k) {
                var sum = 0;

                for (int j = 0; j < k && i + j < s.Length; j++)
                    sum += int.Parse(s[i + j].ToString());

                group.Append(sum);
            }

            s = group.ToString();
        }

        return s;
    }
}