public class Solution {
    public int LargestAltitude(int[] gain) {
        int altitude = 0;
        int result = 0;

        foreach (var i in gain) {
            altitude += i;
            result = Math.Max(result, altitude);
        }
        
        return result;
    }
}