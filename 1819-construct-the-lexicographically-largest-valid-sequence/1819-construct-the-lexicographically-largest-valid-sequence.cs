public class Solution {
    public int[] ConstructDistancedSequence(int n) {
        int[] result = new int[2 * n - 1];
        bool[] used = new bool[n + 1];

        Backtracking(n, 0, result, used);

        return result;
    }

    public bool Backtracking(int n, int index, int[] result, bool[] used) {
        if (index == result.Length) return true;
        
        if (result[index] != 0) return Backtracking(n, index + 1, result, used);

        for (int i = n; i >= 1; i--) {
            if (used[i]) continue;

            result[index] = i;
            used[i] = true;

            if (i == 1) {
                if (Backtracking(n, index + 1, result, used)) return true;
            } else if (index + i < result.Length && result[index + i] == 0) {
                result[index + i] = i;
                if (Backtracking(n, index + 1, result, used)) return true;
                result[index + i] = 0;
            }

            result[index] = 0;
            used[i] = false;
        }

        return false;
    }
}