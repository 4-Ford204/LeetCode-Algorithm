public class Solution {
    public int[] FinalPrices(int[] prices) {
        return MonotonicStack(prices);
    }

    private int[] BruteForce(int[] prices) {
        int n = prices.Length;
        int[] answer = new int[n];
        answer[n - 1] = prices[n - 1];

        for (int i = 0; i < n - 1; i++) {
            answer[i] = prices[i];

            for (int j = i + 1; j < n; j++) {
                if (prices[i] >= prices[j]) {
                    answer[i] -= prices[j];
                    break;
                }
            }
        }

        return answer;
    }

    private int[] MonotonicStack(int[] prices) {
        int n = prices.Length;
        int[] answer = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++) {
            var price = prices[i];
            answer[i] = price;

            while (stack.Count > 0 && prices[stack.Peek()] >= price)
                answer[stack.Pop()] -= price;

            stack.Push(i);
        }

        return answer;
    }
}