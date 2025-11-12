public class Solution {
    public int MinOperations(int[] nums) {
        int n = nums.Length, ones = 0, numsGCD = 0;
        int minLength = n;

        foreach (var num in nums) {
            if (num == 1) ones++;
            numsGCD = GCD(numsGCD, num);
        }

        if (ones > 0) return n - ones;
        if (numsGCD > 1) return -1;

        for (int i = 0; i < n; i++) {
            int currentGCD = 0;

            for (int j = i; j < n; j++) {
                currentGCD = GCD(currentGCD, nums[j]);

                if (currentGCD == 1) {
                    minLength = Math.Min(minLength, j - i + 1);
                    break;
                }
            }
        }

        return minLength + n - 2;
    }

    private int GCD(int a, int b) {
        while (b != 0) (a, b) = (b, a % b);
        return a;
    }
}