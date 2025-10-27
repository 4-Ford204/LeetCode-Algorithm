public class Solution {
    public int NumberOfBeams(string[] bank) {
        int previous = 0, result = 0;

        foreach (var floor in bank) {
            int current = 0;

            foreach (var digit in floor) current += digit & 1;

            if (current != 0) {
                result += previous * current;
                previous = current;
            }
        }

        return result;
    }
}