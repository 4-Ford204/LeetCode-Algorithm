public class Solution {
    public int SmallestNumber(int n) {
        int result = 0;

        while (result < n) result = result << 1 | 1;

        return result;
    }
}