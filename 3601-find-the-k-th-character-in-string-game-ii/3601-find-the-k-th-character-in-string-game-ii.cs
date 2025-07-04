public class Solution {
    public char KthCharacter(long k, int[] operations) {
        int result = 0;
        int temp;
        
        while (k != 1) {
            temp = (int)Math.Log(k, 2);
            if ((1L << temp) == k) temp--;
            k -= (1L << temp);
            if (operations[temp] != 0) result++;
        }

        return (char)('a' + (result % 26));
    }
}