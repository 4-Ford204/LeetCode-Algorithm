public class Solution {
    public bool IsHappy(int n) {
        var hashset = new HashSet<int>();

        while (n != 1 && !hashset.Contains(n)) {
            hashset.Add(n);
            var number = n;
            n = 0;

            while (number > 0) {
                n += (int)Math.Pow(number % 10, 2);
                number /= 10;
            }
        }

        return n == 1;
    }
}