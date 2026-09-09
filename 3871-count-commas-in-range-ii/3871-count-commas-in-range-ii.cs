public class Solution {
    public long CountCommas(long n) {
        var start = 1000L;
        var result = 0L;

        while (start <= n) {
            result += n - start + 1;
            start *= 1000;
        }

        return result;
    }
}