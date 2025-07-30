public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 2;

        if (nums.Length <= 2) return nums.Length;

        for (int i = 2; i < nums.Length; i++){
            if (nums[k - 2] != nums[i]){
                nums[k++] = nums[i];
            }
        }

        return k;
    }
}