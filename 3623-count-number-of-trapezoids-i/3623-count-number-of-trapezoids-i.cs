public class Solution {
    public int CountTrapezoids(int[][] points) {
        int modulo = 1_000_000_007;
        var group = new Dictionary<int, int>();
        long result = 0, prefix = 0;

        foreach (var point in points) {
            int key = point[1];
            if (!group.ContainsKey(key)) group[key] = 0;
            group[key]++; 
        }

        foreach (var value in group.Values) {
            var pair = (long)value * (value - 1) / 2;
            result = (result + prefix * pair) % modulo;
            prefix = (prefix + pair) % modulo;
        }

        return (int)result;
    }
}