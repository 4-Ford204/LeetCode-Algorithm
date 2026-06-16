public class Solution {
    public string ProcessStr(string s) {
        var result = new StringBuilder();

        foreach (var character in s) {
            switch (character) {
                case '*':
                    if (result.Length > 0) result.Length--;
                    break;
                case '#':
                    result.Append(result.ToString());
                    break;
                case '%':
                    var arr = result.ToString().ToCharArray();
                    Array.Reverse(arr);
                    result = new StringBuilder(new string(arr));
                    break;
                default:
                    result.Append(character);
                    break;
            }
        }

        return result.ToString();
    }
}