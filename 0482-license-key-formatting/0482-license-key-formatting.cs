public class Solution {
    public string LicenseKeyFormatting(string s, int k) {
        int count = 0;
        var parsed = new StringBuilder();
        var result = new StringBuilder();

        foreach (var character in s) {
            if (character != '-') parsed.Append(char.ToUpper(character));
        }

        for (int i = parsed.Length - 1; i >= 0; i--) {
            result.Append(parsed[i]);
            count++;

            if (count == k && i != 0) {
                result.Append('-');
                count = 0;
            }
        }

        var chars = result.ToString().ToCharArray();
        Array.Reverse(chars);

        return new string(chars);
    }
}