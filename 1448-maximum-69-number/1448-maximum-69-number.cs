public class Solution {
    public int Maximum69Number (int num) {
        int number = num, count = 0, n = 0;
        bool changeLast = false;

        if (num % 10 == 6) changeLast = true;

        while (number > 0) {
            if (number % 10 == 6) n = count;

            number /= 10;
            count++;
        }

        return n == 0 && !changeLast ?
            num :
            num + (9 - 6) * (int)Math.Pow(10, n);
    }
}