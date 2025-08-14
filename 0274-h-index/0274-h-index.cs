public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        int n = citations.Length, previous = 0, result = 0;

        for (int i = n - 1; i >= 0; i--) {
            if ((n - i) > citations[i]) break;
            result = n - i;
        }

        return result;
    }
}