public class Solution {
    public int PivotInteger(int n) {
        var pivot = Math.Sqrt(n * (n + 1) / 2f);
        return pivot == Math.Ceiling(pivot) ? (int)pivot : -1;
    }
}