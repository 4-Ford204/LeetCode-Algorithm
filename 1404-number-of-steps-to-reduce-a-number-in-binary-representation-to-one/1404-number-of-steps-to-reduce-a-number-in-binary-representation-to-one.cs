public class Solution {
    public int NumSteps(string s) {
        int result = 0, carry = 0;

        for (int i = s.Length - 1; i > 0; i--) {
            int bit = (s[i] - '0') ^ carry;
            result += bit + 1;
            carry |= bit;
        }

        return result + carry;
    }
}