public class Solution {
    public int MaxLength(int[] nums) {
        int n = nums.Length, result = 0;

        for (int i = 0; i < n; i++) {
            long product = nums[i];
            long GCD = nums[i];
            long LCM = nums[i];

            for (int j = i + 1; j < n; j++) {
                product *= nums[j];
                GCD = ComputeGCD(GCD, nums[j]);
                LCM = LCM * nums[j] / ComputeGCD(LCM, nums[j]);

                if (product > GCD * LCM) break;

                if (product == GCD * LCM)
                    result = Math.Max(result, j - i + 1); 
            }
        }

        return result;
    }

    private long ComputeGCD(long a, long b) {
        while (b != 0) (a, b) = (b, a % b);
        return a;
    }
}