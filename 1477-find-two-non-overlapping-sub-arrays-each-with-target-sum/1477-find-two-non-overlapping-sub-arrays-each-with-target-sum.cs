public class Solution {
    public int MinSumOfLengths(int[] arr, int target) {
        int n = arr.Length, sum = 0, start = 0;
        int min = int.MaxValue, answer = int.MaxValue;
        int[] minLength = new int[n];

        for (int end = 0; end < n; end++) {
            sum += arr[end];

            while (sum > target) sum -= arr[start++];

            if (sum == target) {
                int currentLength = end - start + 1;

                if (start > 0 && minLength[start - 1] != int.MaxValue)
                    answer = Math.Min(answer, currentLength + minLength[start - 1]);
                
                min = Math.Min(min, currentLength);
            }

            minLength[end] = min;
        }

        return answer == int.MaxValue ? -1 : answer;
    }
}