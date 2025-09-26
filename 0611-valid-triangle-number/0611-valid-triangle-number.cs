public class Solution {
    public int TriangleNumber(int[] nums) {
        int n = nums.Length, result = 0;
        Array.Sort(nums);

        for (int i = 0; i < n - 2; i++) {
            if (nums[i] == 0) continue;

            for (int j = i + 1, k = i + 2; j < n - 1; j++) {
                while (k < n && IsTriangle(nums[i], nums[j], nums[k])) k++;
                result += k - j - 1;
            }
        }
        
        return result;
    }

    private bool IsTriangle(int x, int y, int z) {
        return x + y > z && x + z > y && y + z > x;
    }
}