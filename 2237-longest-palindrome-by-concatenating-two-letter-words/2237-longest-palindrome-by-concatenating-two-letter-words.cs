public class Solution {
    public int LongestPalindrome(string[] words) {
        int ans = 0;
        Dictionary<string, int> wordCountMap = new();

        foreach(var word in words){
            string rev = $"{word[1]}{word[0]}";

            if(wordCountMap.ContainsKey(rev)){
                wordCountMap[rev]--;
                
                if(wordCountMap[rev] == 0){
                    wordCountMap.Remove(rev);
                }

                ans += 4;
                continue;
            }

            if(!wordCountMap.ContainsKey(word))
                wordCountMap.Add(word, 0);

            wordCountMap[word]++;
        }

        foreach(var kvp in wordCountMap){
            if(kvp.Key[0] == kvp.Key[1] && (kvp.Value&1) != 0){
                ans += 2;
                break;
            }
        }

        return ans;
    }
}