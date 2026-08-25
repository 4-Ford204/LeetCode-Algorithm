public class Solution {
    public int MissingMultiple(int[] nums, int k) {
        int m = 0;
        var map = new bool[101];

        foreach (var num in nums) map[num] = true;

        while (true) {
            m += k;
            if (m > 100 || !map[m]) return m;
        }
    }
}