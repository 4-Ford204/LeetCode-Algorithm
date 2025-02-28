public class Solution {
    public string ShortestCommonSupersequence(string str1, string str2) {
        int str1Length = str1.Length, str2Length = str2.Length;
        string[] previous = new string[str2Length + 1];

        for (int i = 0; i <= str2Length; i++) previous[i] = str2.Substring(0, i);

        for (int i = 1; i <= str1Length; i++) {
            string[] current = new string[str2Length + 1];
            current[0] = str1.Substring(0, i);

            for (int j = 1; j <= str2Length; j++) {
                if (str1[i - 1] == str2[j - 1])
                    current[j] = previous[j - 1] + str1[i - 1];
                else {
                    string s1 = previous[j];
                    string s2 = current[j - 1];
                    current[j] = (s1.Length < s2.Length) ? (s1 + str1[i - 1]) : (s2 + str2[j - 1]);
                }
            }

            previous = current;
        }

        return previous[str2Length];
    }
}