public class Solution {
    public int RepeatedNTimes(int[] nums) {
        int n = nums.Length / 2;
        var freq = new Dictionary<int, int>();

        foreach (var num in nums) {
            if (freq.ContainsKey(num)) return num;
            freq[num] = 1;
        }
        
        return 0;
    }
}