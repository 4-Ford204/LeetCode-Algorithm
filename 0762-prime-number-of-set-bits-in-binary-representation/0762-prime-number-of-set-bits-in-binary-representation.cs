public class Solution {
    public int CountPrimeSetBits(int left, int right) {
        int result = 0;
        var prime = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };

        while (right >= left) {
            int bit = CountBit(right--);
            if (prime.Contains(bit)) result++;
        }
        
        return result;
    }

    private int CountBit(int num) {
        int result = 0;
        
        while (num > 0) {
            num &= num - 1;
            result++;
        }

        return result;
    }
}