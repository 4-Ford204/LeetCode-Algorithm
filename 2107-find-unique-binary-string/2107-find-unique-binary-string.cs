public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        int n = nums.Length;
        string result = string.Empty;

        for (int i = 0; i < n; i++) result += nums[i][i] == '0' ? '1' : '0';

        return result;
    }
}