public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        if (temperatures.Length == 0) return new int[] { 0 };

        int n = temperatures.Length;
        Stack<int> stack = new Stack<int>();
        int[] answer = new int[n];

        for (int i = n - 1; i >= 0; i--) {
            while (stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()]) 
                stack.Pop();
            answer[i] = stack.Count == 0 ? 0 : stack.Peek() - i;
            stack.Push(i);
        }

        return answer;
    }
}