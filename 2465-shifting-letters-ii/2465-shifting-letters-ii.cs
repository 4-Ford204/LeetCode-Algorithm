public class Solution {
    public string ShiftingLetters(string s, int[][] shifts) {
        int n = s.Length, numberShift = 0;
        int[] shiftTotal = new int[n + 1];
        char[] result = new char[n];

        foreach (var shift in shifts) {
            if (shift[2] == 1) {
                shiftTotal[shift[0]]++;
                shiftTotal[shift[1] + 1]--;
            } else {
                shiftTotal[shift[0]]--;
                shiftTotal[shift[1] + 1]++;
            }
        }

        for (int i = 0; i < n; i++) {
            numberShift = (numberShift + shiftTotal[i]) % 26;
            numberShift += numberShift < 0 ? 26 : 0;
            result[i] = (char)('a' + (s[i] - 'a' + numberShift) % 26);
        }

        return new string(result);
    }
}