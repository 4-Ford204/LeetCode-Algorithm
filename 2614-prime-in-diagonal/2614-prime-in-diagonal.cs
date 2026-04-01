public class Solution {
    public int DiagonalPrime(int[][] nums) {
        int n = nums.Length, result = 0;

        for (int i = 0; i < n; i++) {
            int j = n - i - 1;
            if (nums[i][i] > result && IsPrime(nums[i][i])) result = nums[i][i];
            if (nums[i][j] > result && IsPrime(nums[i][j])) result = nums[i][j];
        }

        return result;
    }

    public bool IsPrime(int num) {
        if (num < 2) return false;
        
        for (int i = 2; i <= Math.Sqrt(num); i++) {
            if (num % i == 0) return false;
        }

        return true;
    }
}