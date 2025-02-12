public class Solution {
    public int AddDigits(int num) {
        while (num >= 10) {
            int nextNumber = 0;

            while (num > 0) {
                nextNumber += num % 10;
                num /= 10;
            }

            num = nextNumber;
        }

        return num;
    }
}