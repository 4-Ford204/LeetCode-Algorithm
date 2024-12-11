public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        IList<IList<int>> result = new List<IList<int>>();
        Backtracking(k, n, result, new List<int>(), 1);       
        return result;
    }

    private void Backtracking(int k, int n, IList<IList<int>> result, List<int> tracking, int index) {
        if (tracking.Count >= k) {
            int total = 0;
            foreach (var number in tracking) total += number;
            if (total == n) result.Add(new List<int>(tracking));
        } else {
            for (int i = index; i < 10; i++) {
                tracking.Add(i);
                Backtracking(k, n, result, tracking, i + 1);
                tracking.Remove(i);
            }
        }
    }
}