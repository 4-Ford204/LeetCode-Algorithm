public class Solution {
    public int MajorityElement(int[] nums) {
        int result = 0, current = 0;

        foreach (var num in nums) {
            if (current == 0) result = num;

            if (num == result) current++;
            else current--;
        }

        return result;
    }
}