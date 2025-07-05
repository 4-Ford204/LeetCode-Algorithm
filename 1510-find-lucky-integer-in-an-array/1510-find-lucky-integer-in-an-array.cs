public class Solution {
    public int FindLucky(int[] arr) {
        var freq = new Dictionary<int, int>();
        int result = -1;

        foreach (var num in arr) {
            if (!freq.ContainsKey(num)) freq[num] = 0;
            freq[num]++;
        }

        foreach (var (key, value) in freq) {
            if (key == value && key > result) result = key;
        }

        return result;
    }
}