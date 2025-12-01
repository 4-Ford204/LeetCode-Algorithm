public class Solution {
    public long MaxRunTime(int n, int[] batteries) {
        long right = 0;

        foreach (int b in batteries)
            right += b;

        right /= n;
        
        long left = 1;

        while (left < right)
        {
            long mid = (left + right) / 2 + 1;
            long available = 0;

            foreach (int b in batteries)
                available += b < mid ? b : mid;

            if (n * mid <= available)
                left = mid;
            else 
                right = mid - 1;
        }

        return left;
    }
}