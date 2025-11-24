public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        int n = nums.Length, current = 0;
        var result = new bool[n];

        for (int i = 0; i < n; i++) {
            current = ((current << 1) + nums[i]) % 5;
            result[i] = current == 0;
        }

        return result;
    }
}