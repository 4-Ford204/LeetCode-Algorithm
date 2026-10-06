public class Solution {
    public int MinAddToMakeValid(string s) {
        int open = 0, result = 0;

        foreach (var character in s) {
            if (character == '(') open++;
            else if (character == ')' && open > 0) open--;
            else result++;
        }

        return result + open;
    }
}