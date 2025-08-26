public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0, j = numbers.Length - 1;

        while (i < j) {
            int sum = numbers[i] + numbers[j];

            if (sum > target) j--;
            else if (sum < target) i++;
            else return new int[] { ++i, ++j };  
        }

        return new int[2];
    }
}