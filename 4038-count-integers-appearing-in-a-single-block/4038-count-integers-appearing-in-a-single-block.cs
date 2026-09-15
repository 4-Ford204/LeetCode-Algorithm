public class Solution {
    public int CountSpecialIntegers(int[] nums) {
        int previous = 0, result = 0;
        var arr = new int[101];

        foreach (var num in nums) {
            if (num == previous) continue;

            switch (arr[num]) {
                case 0: result++; arr[num] = 1; break;
                case 1: result--; arr[num] = 2; break;
            }

            previous = num;
        }

        return result;
    }
}