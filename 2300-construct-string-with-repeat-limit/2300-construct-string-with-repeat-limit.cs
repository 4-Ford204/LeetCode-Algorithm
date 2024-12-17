public class Solution {
    public string RepeatLimitedString(string s, int repeatLimit) {
        int current = 25;
        int[] frequency = new int[26];
        StringBuilder repeatLimitedString = new StringBuilder();

        for (int i = 0; i < s.Length; i++) frequency[s[i] - 'a']++;
            
        while (current >= 0) {
            if (frequency[current] == 0) {
                current--;
                continue;
            }

            int repeat = Math.Min(frequency[current], repeatLimit);
            frequency[current] -= repeat;
            
            for (int i = 0; i < repeat; i++)
                repeatLimitedString.Append((char)(current + 'a'));

            if (frequency[current] > 0) {
                int next = current - 1;

                while (next >= 0 && frequency[next] == 0) next--;

                if (next < 0) break;

                repeatLimitedString.Append((char)(next + 'a'));
                frequency[next]--;
            }
        }

        return repeatLimitedString.ToString();
    }
}