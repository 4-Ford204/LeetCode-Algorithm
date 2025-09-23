public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] revision1 = version1.Split('.');
        string[] revision2 = version2.Split('.');
        int n = Math.Max(revision1.Length, revision2.Length);

        for (int i = 0; i < n; i++) {
            int value1 = i < revision1.Length ? int.Parse(revision1[i]) : 0;
            int value2 = i < revision2.Length ? int.Parse(revision2[i]) : 0;

            if (value1 < value2) return -1;
            if (value1 > value2) return 1;
        }

        return 0;
    }
}