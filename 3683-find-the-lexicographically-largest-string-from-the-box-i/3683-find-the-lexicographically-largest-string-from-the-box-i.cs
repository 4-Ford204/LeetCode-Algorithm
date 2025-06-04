public class Solution {
    public string AnswerString(string word, int numFriends) {
        int start = 0, end = 1;

        if (numFriends == 1) return word;

        while (end < word.Length) {
            int i = 0;

            while (end + i < word.Length && word[start + i] == word[end + i]) i++;

            if (end + i < word.Length && word[start + i] < word[end + i])
                (start, end) = (end, Math.Max(end, start + i) + 1);
            else
                end = end + i + 1;
        }

        string largest = word.Substring(start);
        return largest.Substring(0, Math.Min(largest.Length, word.Length - numFriends + 1));
    }
}