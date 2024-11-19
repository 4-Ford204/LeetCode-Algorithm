public class Solution {
    public long MaximumSubarraySum(int[] nums, int k) {
        int[] tracking = new int[100001];
        long result = 0;
        long currentResult = 0;
        int uniqueNumber = 0;

        for (int i = 0; i < k; i++) {
            tracking[nums[i]]++;
            currentResult += nums[i];

            if (tracking[nums[i]] == 1) uniqueNumber++;
        }

        if (uniqueNumber == k) result = currentResult;

        for (int i = k; i < nums.Length; i++) {
            currentResult += nums[i] - nums[i - k];
                     
            tracking[nums[i]]++;
            if (tracking[nums[i]] == 1) uniqueNumber++;

            tracking[nums[i - k]]--;
            if (tracking[nums[i - k]] == 0) uniqueNumber--;

            if (uniqueNumber == k) result = Math.Max(result, currentResult);
        }

        return result;
    }
}