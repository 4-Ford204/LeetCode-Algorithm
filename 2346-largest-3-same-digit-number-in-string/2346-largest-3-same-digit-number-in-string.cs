public class Solution {
    public string LargestGoodInteger(string num) {
        var result = "";

        for (int i = 2; i < num.Length; i++) {
            if (num[i] == num[i - 1] && num[i] == num[i - 2]) {
                var current = num.Substring(i - 2, 3);

                if (string.Compare(result, current) < 0)
                    result = current;
            }
        }

        return result;
    }
}