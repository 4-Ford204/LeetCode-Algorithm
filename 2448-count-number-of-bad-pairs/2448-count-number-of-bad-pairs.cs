public class Solution {
    public long CountBadPairs(int[] nums) {
        long badPairs = 0;
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int position = 0; position < nums.Length; position++) {
            int key = position - nums[position];
            int goodPairs = dictionary.TryGetValue(key, out var value) ? value : 0;
            badPairs += position - goodPairs;
            dictionary[key] = goodPairs + 1;
        }

        return badPairs;
    }
}