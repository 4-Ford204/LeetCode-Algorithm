public class Solution {
    public int MaximumSum(int[] nums) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        int result = -1;

        foreach (var num in nums) {
            int key = 0, number = num;

            while (number > 0 ) {
                key += number % 10;
                number /= 10;
            }

            if (!dictionary.TryGetValue(key, out var value)) dictionary.Add(key, num);
            else {
                result = Math.Max(result, num + value);
                dictionary[key] = Math.Max(value, num);
            } 
        }

        return result;
    }
}