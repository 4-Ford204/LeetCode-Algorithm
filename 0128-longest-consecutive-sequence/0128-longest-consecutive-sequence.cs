public class Solution {
    public int LongestConsecutive(int[] nums) {
        var dictionary = new Dictionary<int, int>();
        int result = 0;

        for (int i = 0; i < nums.Length; i++) dictionary[nums[i]] = i;

        foreach (var (num, index) in dictionary) {
            if (nums[index] != num) continue;

            int number, longest = 1;
            nums[index] = num + 1;

            number = num - 1;
            while (dictionary.TryGetValue(number, out int numberIndex)) {
                number--;
                longest++;
                nums[numberIndex]++;
            }

            number = num + 1;
            while (dictionary.TryGetValue(number, out int numberIndex)) {
                number++;
                longest++;
                nums[numberIndex]++;
            }

            result = Math.Max(result, longest);
        }

        return result;
    }

    private int HashSet(int[] nums) {
        if (nums.Length == 0) return 0;

        var hashset = new HashSet<int>(nums);
        int result = 0;

        foreach (var num in hashset) {
            if (!hashset.Contains(num - 1)) {
                int number = num + 1, longest = 1;

                while (hashset.Contains(number++)) longest++;

                result = Math.Max(result, longest);
            }
        }

        return result;
    }
}