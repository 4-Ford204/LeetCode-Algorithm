public class Solution {
    int max;
    List<string> result = new List<string>();

    public IList<string> GenerateParenthesis(int n) {
        max = n;
        Backtracking(0, 0, "");
        return result; 
    }

    private void Backtracking(int start, int end, string current) {
        if (start == end && start == max) {
            result.Add(current);
            return;
        }

        if (start < max) Backtracking(start + 1, end, current + "(");
        if (end < start) Backtracking(start, end + 1, current + ")");
    }
}