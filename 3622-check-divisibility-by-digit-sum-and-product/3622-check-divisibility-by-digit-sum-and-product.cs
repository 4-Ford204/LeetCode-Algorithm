public class Solution {
    public bool CheckDivisibility(int n) {
        int original = n;
        var sum = 0L;
        var product = 1L;
        
        while (n > 0) {
            int digit = n % 10;
            sum += digit;
            product *= digit;
            n /= 10;
        }

        return (original % (sum + product)) == 0;
    }
}