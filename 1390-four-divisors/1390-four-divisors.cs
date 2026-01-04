public class Solution {
    public int SumFourDivisors(int[] nums) {
        int result = 0;

        foreach (var num in nums) {
            int count = 0, sum = 0;
            
            for (int i = 1; i * i <= num; i++) {
                if (count > 4) break;
                
                if (num % i == 0) {
                    int j = num / i;

                    if (i == j) {
                        count += 1;
                        sum += i;
                    } else {
                        count += 2;
                        sum += i + j;
                    }
                }
            }

            if (count == 4) result += sum;
        }

        return result;
    }
}