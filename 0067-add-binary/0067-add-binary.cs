public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length, j = b.Length, remainder = 0;
        StringBuilder result = new StringBuilder();

        if (i < j) {
            (a, b) = (b, a);
            (i, j) = (j, i);
        }

        while (i-- > 0) {
            int aChar = a[i] - '0';
            int bChar = --j < 0 ? 0 : b[j] - '0';
            int sum = aChar + bChar + remainder;
            result.Append(sum % 2);
            remainder = sum / 2;
        }

        if (remainder == 1) result.Append(1);

        var charArray = result.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new String(charArray);
    }
}