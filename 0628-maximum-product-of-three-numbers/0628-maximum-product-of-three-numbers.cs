public class Solution {
    public int MaximumProduct(int[] nums) {
        int L1 = int.MaxValue, L2 = int.MaxValue;
        int R1 = int.MinValue, R2 = int.MinValue, R3 = int.MinValue;

        foreach (var num in nums) {
            if (num < L1) (L1, L2) = (num, L1);
            else if (num < L2) L2 = num;

            if (num > R3) (R1, R2, R3) = (R2, R3, num);
            else if (num > R2) (R1, R2) = (R2, num);
            else if (num > R1) R1 = num;
        }

        return Math.Max(L1 * L2 * R3, R1 * R2 * R3);
    }
}