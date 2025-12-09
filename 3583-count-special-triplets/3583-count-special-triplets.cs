public class Solution {
    public int SpecialTriplets(int[] nums) {
        int modulo = 1_000_000_007;
        var map = new Dictionary<int, int>();
        var previousMap = new Dictionary<int, int>();
        long result = 0;

        foreach (var num in nums) {
            if (map.ContainsKey(num))
                map[num]++;
            else
                map[num] = 1;
        }

        foreach (var num in nums) {
            if (
                map.TryGetValue(num * 2, out var total) &&
                previousMap.TryGetValue(num * 2, out var previous)
            )
                result = (result + (long)previous * ((num == 0 ? --total : total) - previous)) % modulo;
            
            if (previousMap.ContainsKey(num))
                previousMap[num]++;
            else
                previousMap[num] = 1;
        }

        return (int)result;
    }
}