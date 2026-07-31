public class Solution {
    public int MinimumPushes(string word) {
        int result = 0;
        var arr = new int[26];

        foreach (var character in word) arr[character - 'a']++;

        Array.Sort(arr);
        Array.Reverse(arr);

        for (int i = 0; i < arr.Length; i++) result += arr[i] * (i / 8 + 1);

        return result;
    }
}