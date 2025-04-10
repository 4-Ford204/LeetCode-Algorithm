public class Solution {
    public long NumberOfPowerfulInt(long start, long finish, int limit, string s) {
        string left = start.ToString();
        string right = finish.ToString();
        int length = right.Length, preLength = length - s.Length;
        left = left.PadLeft(length, '0');
        long[] memoization = new long[length];
        Array.Fill(memoization, -1);

        return DFS(0, true, true, left, right, limit, s, preLength, memoization);
    }

    private long DFS(int i, bool limitLeft, bool limitRight, string left, string right, int limit, string s, int preLength, long[] memoization) {
        if (i == left.Length) return 1;
        if (!limitLeft && !limitRight && memoization[i] != -1) return memoization[i];

        int charLeft = limitLeft ? left[i] - '0' : 0;
        int charRight = limitRight ? right[i] - '0' : 9;
        long result = 0;

        if (i < preLength) {
            for (int digit = charLeft; digit <= Math.Min(charRight, limit); digit++) {
                result += DFS(i + 1, limitLeft && digit == charLeft, limitRight && digit == charRight, left, right, limit, s, preLength, memoization);
            }
        } else {
            int x = s[i - preLength] - '0';

            if (charLeft <= x && x <= Math.Min(charRight, limit)) {
                result += DFS(i + 1, limitLeft && x == charLeft, limitRight && x == charRight, left, right, limit, s, preLength, memoization);
            }
        }

        if (!limitLeft && !limitRight) memoization[i] = result;

        return result;
    }
}