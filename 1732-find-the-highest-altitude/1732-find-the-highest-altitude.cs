public class Solution {
    public int LargestAltitude(int[] gain) {
        int current = 0, result = 0;

        foreach (var i in gain) {
            current += i;
            result = Math.Max(result, current);
        }
        
        return result;
    }
}