public class Solution {
    public bool CanChange(string start, string target) {
        int i = 0, j = 0, n = start.Length;
        
        while (i < n && j < n) {
            while (i < n && start[i] == '_') i++;
            while (j < n && target[j] == '_') j++;

            if (i == n || j == n) break;
            if (start[i] != target[j]) return false;
            else {
                if (start[i] == 'L' && i < j) return false;
                if (start[i] == 'R' && i > j) return false;

                i++;
                j++;
            }
        }

        while (i < n) if (start[i++] != '_') return false;
        while (j < n) if (target[j++] != '_') return false;

        return true;
    }
}