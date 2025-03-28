public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int n = letters.Length;
        int lo = 0, hi = n - 1;
        
        while (lo <= hi) {
            int mid = lo + (hi - lo) / 2;
            
            if (letters[mid] <= target) {
                lo = mid + 1;
            } 
            else {
                hi = mid - 1;
            }
        }
        
        return lo < n ? letters[lo] : letters[0];
    }
}