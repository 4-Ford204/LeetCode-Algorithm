public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        var result = new List<int>();

        for (int i = left; i <= right; i++) {
            var num = i;

            while (num > 0) {
                var digit = num % 10;
                if (digit == 0 || i % digit != 0) break;
                num /= 10;
            }

            if (num == 0) result.Add(i);
        }

        return result;
    }
}