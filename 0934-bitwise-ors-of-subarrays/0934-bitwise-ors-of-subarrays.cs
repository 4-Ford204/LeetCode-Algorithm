public class Solution {
    public int SubarrayBitwiseORs(int[] arr) {
        HashSet<int> next = new(), current = new(), result = new();

        foreach (var i in arr) {
            next.Clear();
            next.Add(i);

            foreach (var j in current) next.Add(i | j);

            foreach (var j in next) result.Add(j);

            (current, next) = (next, current);
        }

        return result.Count;
    }
}