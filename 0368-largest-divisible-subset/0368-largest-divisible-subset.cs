public class Solution
{
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        int n = nums.Length;
        List<int>[] dp = new List<int>[n];
        List<int> result = new List<int>();
        Array.Sort(nums);

        for (int i = 0; i < n; i++) dp[i] = new List<int> { nums[i] };

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] == 0 && dp[j].Count + 1 > dp[i].Count)
                {
                    dp[i] = new List<int>(dp[j]);
                    dp[i].Add(nums[i]);
                }
            }
        }

        foreach (var subset in dp)
        {
            if (subset.Count > result.Count) result = subset;
        }

        return result;
    }
}
