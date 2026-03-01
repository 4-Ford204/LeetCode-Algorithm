public class Solution {
    public int MinPartitions(string n) {
        int result = 0;

        foreach (var num in n)
            result = Math.Max(result, num - '0');

        return result;
    }
}