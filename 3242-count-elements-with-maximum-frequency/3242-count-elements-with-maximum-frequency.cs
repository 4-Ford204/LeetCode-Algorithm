public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        var dictionary = new Dictionary<int, int>();
        int max = 0, result = 0;

        foreach (var num in nums) {
            if (!dictionary.ContainsKey(num)) dictionary[num] = 0;
            dictionary[num]++;
            
            if (dictionary[num] > max) {
                max = dictionary[num];
                result = max;
            }
            else if (dictionary[num] == max)
                result += max;
        }

        return result;
    }
}