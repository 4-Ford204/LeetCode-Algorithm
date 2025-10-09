public class Solution {
    public long MinTime(int[] skill, int[] mana) {
        int n = skill.Length, m = mana.Length;
        var sum = (long)skill[0] * mana[0];
        var prefix = new long[n];

        for (int i = 1; i < n; i++) prefix[i] = prefix[i - 1] + skill[i];

        for (int j = 1; j < m; j++) {
            var max = (long)skill[0] * mana[j];

            for (int i = 1; i < n; i++)
                max = Math.Max(max, prefix[i] * mana[j - 1] - prefix[i - 1] * mana[j]);

            sum += max;
        }

        return sum + prefix[^1] * mana[^1];
    }
}