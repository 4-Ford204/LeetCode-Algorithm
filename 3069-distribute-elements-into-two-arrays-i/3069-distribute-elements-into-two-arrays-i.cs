public class Solution {
    public int[] ResultArray(int[] nums) {
        int n = nums.Length;
        var arr1 = new List<int>() { nums[0] };
        var arr2 = new List<int>() { nums[1] };

        for (int i = 2; i < n; i++) {
            if (arr1[^1] > arr2[^1]) arr1.Add(nums[i]);
            else arr2.Add(nums[i]);
        }

        arr1.AddRange(arr2);
        
        return arr1.ToArray();
    }
}