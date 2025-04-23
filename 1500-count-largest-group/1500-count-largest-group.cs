public class Solution {
    public int CountLargestGroup(int n) {
        int[] group = new int[37];
        int largest = 0, result = 0;

        for (int i = 1; i <= n; i++) {
            int number = i, total = 0;

            while (number > 0) {
                total += number % 10;
                number /= 10;
            }

            if (++group[total] == largest) result++;
            else if (group[total] > largest) {
                largest = group[total];
                result = 1;
            }
        }

        return result;
    }
}