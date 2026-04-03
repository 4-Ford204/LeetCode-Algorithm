public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        var answer = new int[n];

        for (int i = n - 2; i >= 0; i--) {
            int j = i + 1;

            while (true) {
                if (temperatures[j] > temperatures[i]) {
                    answer[i] = j - i;
                    break;
                }
                else if (answer[j] == 0) {
                    answer[i] = 0;
                    break;
                }
                else j += answer[j];
            }
        }

        return answer;
    }
}