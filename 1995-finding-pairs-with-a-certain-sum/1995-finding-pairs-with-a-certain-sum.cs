public class FindSumPairs {
    private int[] nums1;
    private int[] nums2;
    private Dictionary<int, int> freq1;
    private Dictionary<int, int> freq2;

    public FindSumPairs(int[] nums1, int[] nums2) {
        this.nums1 = nums1;
        this.nums2 = nums2;
        freq1 = new Dictionary<int, int>();
        freq2 = new Dictionary<int, int>();

        foreach (var num in nums1) {
            if (!freq1.ContainsKey(num)) freq1[num] = 0;
            freq1[num]++;
        }

        foreach (var num in nums2) {
            if (!freq2.ContainsKey(num)) freq2[num] = 0;
            freq2[num]++;
        }
    }
    
    public void Add(int index, int val) {
        int prev = nums2[index], next = prev + val;
        freq2[prev]--;
        nums2[index] = next;

        if (!freq2.ContainsKey(next)) freq2[next] = 0;
        freq2[next]++;
    }
    
    public int Count(int tot) {
        int result = 0;

        foreach (var (num1, count1) in freq1) {
            int num2 = tot - num1;
            if (freq2.ContainsKey(num2)) result += freq2[num2] * count1;
        }

        return result;
    }
}

/**
 * Your FindSumPairs object will be instantiated and called as such:
 * FindSumPairs obj = new FindSumPairs(nums1, nums2);
 * obj.Add(index,val);
 * int param_2 = obj.Count(tot);
 */