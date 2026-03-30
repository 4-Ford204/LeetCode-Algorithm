public class Solution {
    public bool CheckStrings(string s1, string s2) {
        int n = s1.Length;
        int[,] arr = new int[26, 2];

        for (int i = 0; i < n; i++) {
            int j = i % 2;
            arr[s1[i] - 'a', j]++;
            arr[s2[i] - 'a', j]--;
        }

        for (int i = 0; i < 26; i++) {
            if (arr[i, 0] != 0 || arr[i, 1] != 0)
                return false;
        }

        return true;
    }
}