public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        return patterns.Count(x => word.Contains(x));
    }
}