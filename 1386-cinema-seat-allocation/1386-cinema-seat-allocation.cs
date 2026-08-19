public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        int a = 0b11110000;
        int b = 0b11000011;
        int c = 0b00001111;
        var reserved = new Dictionary<int, int>();

        foreach (var seat in reservedSeats) {
            if (seat[1] == 1 || seat[1] == 10) continue;
            if (!reserved.ContainsKey(seat[0])) reserved[seat[0]] = 0;

            reserved[seat[0]] |= (1 << (seat[1] - 2));
        }

        int result = (n - reserved.Count) * 2;

        foreach (var kvp in reserved) {
            int bitmask = kvp.Value;
            if ((bitmask | a) == a || (bitmask | b) == b || (bitmask | c) == c)
                result++;
        }

        return result;
    }
}