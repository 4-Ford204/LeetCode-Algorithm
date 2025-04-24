public class Solution {
    public int CountCompleteSubarrays(int[] nums) {
        var visited = new Dictionary<int, int>();
        int distinct = 0, left = 0, current = 0, result = 0;

        foreach (var num in nums) {
            if (!visited.ContainsKey(num)) {
                visited[num] = 0;
                distinct++;
            }
        }

        for (int right = 0; right < nums.Length; right++) {
            if (visited[nums[right]] == 0) current++;
            visited[nums[right]]++;

            while (current == distinct) {
                if (--visited[nums[left]] == 0) current--;
                left++;
            }

            result += left;
        }

        return result;
    }
}