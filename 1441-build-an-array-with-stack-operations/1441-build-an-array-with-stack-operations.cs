public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        var result = new List<string>();

        for (int i = 1, j = 0; i <= n && j < target.Length; i++) {
            if (i == target[j]) {
                result.Add("Push");
                j++;
            } else {
                result.Add("Push");
                result.Add("Pop");
            }
        }

        return result;
    }
}