public class Solution {
    public int NumWays(string[] words, string target) {
        int wordLength = words[0].Length, targetLength = target.Length, mod = 1_000_000_007;
        int[,] charFrequency = new int[wordLength, 26];
        long[,] dp = new long[wordLength + 1, targetLength + 1];

        foreach (var word in words) 
            for (int i = 0; i < wordLength; i++) charFrequency[i, word[i] - 'a']++;
        
        for (int currentWord = 0; currentWord <= wordLength; currentWord++)
            dp[currentWord, 0] = 1;

        for (int currentWord = 1; currentWord <= wordLength; currentWord++) {
            for (int currentTarget = 1; currentTarget <= targetLength; currentTarget++) {
                int currentPosition = target[currentTarget - 1] - 'a';

                dp[currentWord, currentTarget] = dp[currentWord - 1, currentTarget];
                dp[currentWord, currentTarget] += (charFrequency[currentWord - 1, currentPosition] * dp[currentWord - 1, currentTarget - 1]) % mod;
                dp[currentWord, currentTarget] %= mod;
            }
        }

        return (int)dp[wordLength, targetLength];
    }
}