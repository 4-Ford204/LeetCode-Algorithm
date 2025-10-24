public class Solution {
    public int NextBeautifulNumber(int n) {
        for (int i = n + 1; i <= 1224444; i++) {
            if (IsBalance(i)) return i;
        }

        return -1;
    }

    private bool IsBalance(int num) {
        int[] count = new int[10];

        while (num > 0) {
            count[num % 10]++;
            num /= 10;
        }

        for (int i = 0; i < 10; i++) {
            if (count[i] > 0 && count[i] != i) return false;
        }

        return true;
    }
}