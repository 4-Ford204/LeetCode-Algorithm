public class Solution {
    public void SortColors(int[] nums) {
        int left = 0, right = nums.Length - 1, current = 0;
        
        while (left <= right) {
            if (nums[left] == 0) {
                nums[current++] = 0;
                left++;
            } else if (nums[left] == 2) {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                right--;
            } else 
                left++;
        }

        while (current < left) nums[current++] = 1;
    }

    private void Frequency(int[] nums) {
        int[] freq = new int[3];
        int current = 0;
        
        foreach (var num in nums) freq[num]++;

        for (int i = 0; i < freq.Length; i++) {
            int next = current + freq[i];
            for (int j = current; j < next; j++) nums[j] = i;
            current = next;
        }
    }
}