public class Solution {
    public bool IsGood(int[] nums) {
        int n = nums.Length;
        var arr = new int[n];

        foreach (var num in nums) {
            if (num < 1 || num >= n) return false;
            if (num < n - 1 && arr[num] > 0) return false;
            if (num == n - 1 && arr[num] > 1) return false;
            arr[num]++;
        }

        return true;
    }
}