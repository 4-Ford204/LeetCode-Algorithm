public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        int n = s.Length, i = 1;
        string[] result = new string[(int)Math.Ceiling(n * 1.0 / k)];
        StringBuilder builder = new StringBuilder();
        builder.Append(s[0]);

        for (; i < n; i++) {
            if (i % k == 0) {
                result[(i - 1) / k] = builder.ToString();
                builder.Clear(); 
            }
            builder.Append(s[i]);
        }

        for (int j = 0; j < (k - (i % k)) % k; j++) builder.Append(fill);

        result[result.Length - 1] = builder.ToString();
        return result;
    }
}