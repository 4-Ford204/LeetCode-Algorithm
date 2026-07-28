public class Solution {
    public string SmallestPalindrome(string s) {
        var arr = new int[26];
        string L = "", M = "", R = "";

        foreach (var character in s) arr[character - 'a']++;

        for (int i = 0; i < arr.Length; i++) {
            var count = arr[i];
            var character = (char)(i + 'a');

            if (count == 0) continue;
            if (count % 2 != 0) M += character;
            
            L = L + new string(character, count / 2);
            R = new string(character, count / 2) + R;
        }
        
        return L + M + R;
    }
}