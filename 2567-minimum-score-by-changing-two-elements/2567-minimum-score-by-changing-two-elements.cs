public class Solution {
    public int MinimizeSum(int[] nums) {
        var min = new int[] { int.MaxValue, int.MaxValue, int.MaxValue };
        var max = new int[] { int.MinValue, int.MinValue, int.MinValue };

        foreach (var num in nums) {
            if (num < min[0]) (min[0], min[1], min[2]) = (num, min[0], min[1]);
            else if (num < min[1]) (min[1], min[2]) = (num, min[1]);
            else if (num < min[2]) min[2] = num;

            if (num > max[0]) (max[0], max[1], max[2]) = (num, max[0], max[1]);
            else if (num > max[1]) (max[1], max[2]) = (num, max[1]);
            else if (num > max[2]) max[2] = num;
        }

        return Math.Min(max[0] - min[2], Math.Min(max[1] - min[1], max[2] - min[0]));
    }
}