public class Solution {
    public int BeautifulSplits(int[] nums) {
        int n = nums.Length, result = 0;
        int[,] longestPrefix = new int[n, n];

        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                if (nums[i] != nums[j]) continue;
                else longestPrefix[i, j] = i > 0 ? longestPrefix[i - 1, j - 1] + 1 : 1;
            }
        }

        for (int i = 1; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++) {
                int length1 = i;
                int length2 = j - i;
                int length3 = n - j;
                bool first = length1 <= length2 && longestPrefix[i - 1, i - 1 + length1] == length1;
                bool second = length2 <= length3 && longestPrefix[j - 1, j - 1 + length2] >= length2;

                if (first || second) result++;
            }
        }

        return result;
    }
}