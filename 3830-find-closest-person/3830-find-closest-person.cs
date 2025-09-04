public class Solution {
    public int FindClosest(int x, int y, int z) {
        var result = Math.Abs(x - z) - Math.Abs(y - z);
        return result < 0 ? 1 : result > 0 ? 2 : 0;
    }
}