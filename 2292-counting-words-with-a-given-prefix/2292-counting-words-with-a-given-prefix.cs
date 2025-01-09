public class Solution {
    public int PrefixCount(string[] words, string pref) {
        return words.Where(word => word[..Math.Min(pref.Length, word.Length)].Equals(pref)).Count();
    }
}