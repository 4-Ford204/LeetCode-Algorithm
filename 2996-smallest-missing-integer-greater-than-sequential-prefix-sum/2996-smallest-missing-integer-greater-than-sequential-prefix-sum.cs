public class Solution {
    public int MissingInteger(int[] nums) {
        int n = nums.Length, prefixLength = 1;
        var hashset = new HashSet<int>(nums);

        for (int i = 1; i < n; i++) {
            if (nums[i] != nums[i - 1] + 1) break;
            prefixLength++;
        }

        int sum = (nums[0] + nums[prefixLength - 1]) * prefixLength / 2;

        while (hashset.Contains(sum)) sum++;

        return sum;
    }
}