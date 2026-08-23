public class Solution {
    public bool SumGame(string num) {
        int n = num.Length;
        int[,] arr = new int[2, 2];

        for (int i = 0; i < n; i++) {
            int index = i < n / 2 ? 0 : 1;

            if (num[i] == '?') arr[index, 0]++;
            else arr[index, 1] += num[i] - '0';
        }

        return 
            ((arr[0, 0] + arr[1, 0]) % 2 == 1) ||
            (arr[0, 1] - arr[1, 1] != (arr[1, 0] - arr[0, 0]) * 9 / 2);
    }
}