public class Solution {
    public IList<int> ReplaceNonCoprimes(int[] nums) {
        var result = new List<int>();
        result.Add(nums[0]);

        for (int i = 1; i < nums.Length; i++) {
            result.Add(nums[i]);

            while (result.Count > 1) {
                int n = result.Count;
                int x = result[n - 2], y = result[n - 1];
                int gcd = GCD(x, y);

                if (gcd == 1) break;

                result[n - 2] = (int)((long)x * y / gcd);
                result.RemoveAt(n - 1);
            }
        }

        return result;
    }

    private int GCD(int x, int y) {
        while (y != 0) (x, y) = (y, x % y);
        return x;
    }
}