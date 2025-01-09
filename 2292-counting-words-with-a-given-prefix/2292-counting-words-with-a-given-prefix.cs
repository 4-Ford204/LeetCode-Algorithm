public class Solution {
    public int PrefixCount(string[] words, string pref) {
        return StartsWith(words, pref);
    }

    private int Substring(string[] words, string pref)
        => words.Where(word => word[..Math.Min(pref.Length, word.Length)].Equals(pref)).Count();
    
    private int StartsWith(string[] words, string pref)
        => words.Where(word => word.StartsWith(pref)).Count();
}