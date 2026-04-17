public class Solution {
    public int MinMirrorPairDistance(int[] nums) {
        int n = nums.Length, result = n;
        var map = new Dictionary<int, int>();

        for (int i = 0; i < n; i++) {
            int num = nums[i];

            if (map.ContainsKey(num))
                result = Math.Min(result, i - map[num]);

            map[ReverseNumber(num)] = i;
        }

        return result == n ? -1 : result;
    }

    private int ReverseNumber(int num) {
        int reversed = 0;

        while (num > 0) {
            reversed = reversed * 10 + num % 10;
            num /= 10;
        }

        return reversed;
    }
}