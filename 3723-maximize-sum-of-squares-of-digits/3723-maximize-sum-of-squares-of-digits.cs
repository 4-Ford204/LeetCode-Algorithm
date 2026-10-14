public class Solution {
    public string MaxSumOfSquares(int num, int sum) {
        if (sum > num * 9) return "";
        
        var result = new StringBuilder();

        result.Append('9', sum / 9);
        if (sum % 9 > 0) result.Append(sum % 9);
        result.Append('0', num - result.Length);

        return result.ToString();
    }
}