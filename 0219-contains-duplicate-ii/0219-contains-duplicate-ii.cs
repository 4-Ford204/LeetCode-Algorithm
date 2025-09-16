public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        return Dictionary(nums, k);
    }

    private bool HashSet(int[] nums, int k) {
        var hashset = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (i > k) hashset.Remove(nums[i - k - 1]);
            if (!hashset.Add(nums[i])) return true;
        }

        return false;
    }

    private bool Dictionary(int[] nums, int k) {
        var dictionary = new Dictionary<int, int>(nums.Length);

        for (int i = 0; i < nums.Length; i++) {
            if (dictionary.TryGetValue(nums[i], out int j)) {
                if (i - j <= k) return true;
            }

            dictionary[nums[i]] = i;
        }

        return false;
    }
}