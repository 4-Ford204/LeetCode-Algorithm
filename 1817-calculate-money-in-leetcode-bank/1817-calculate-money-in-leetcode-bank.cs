public class Solution {
    public int TotalMoney(int n) {
        int result = 0;

        for (int i = 1; i <= 7; i++) {
            int freq = (n / 7) + (n % 7 >= i ? 1 : 0);
            result += freq * i + freq * (freq - 1) / 2;
        }

        return result;
    }
}