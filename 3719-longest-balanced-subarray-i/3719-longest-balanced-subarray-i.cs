public class Solution {
    public int LongestBalanced(int[] nums) {
        int n = nums.Length, result = 0;

        for (int i = 0; i < n; i++) {
            var hashset = new HashSet<int>[2];
            hashset[0] = new HashSet<int>();
            hashset[1] = new HashSet<int>();

            for (int j = i; j < n; j++) {
                var num = nums[j];
                hashset[(num & 1) == 0 ? 0 : 1].Add(num);

                if (hashset[0].Count == hashset[1].Count)
                    result = Math.Max(result, j - i + 1);
            }
        }

        return result;
    }
}