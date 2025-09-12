public class Solution {
    public bool DoesAliceWin(string s) {
        foreach (var character in s) {
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                return true;
        }

        return false;
    }
}