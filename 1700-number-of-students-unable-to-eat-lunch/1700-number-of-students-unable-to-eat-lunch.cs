public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int n = students.Length, zeros = 0, ones = 0;

        foreach (int student in students) {
            if (student == 0) zeros++;
            else ones++;
        }

        foreach (int sandwich in sandwiches) {
            if (
                (sandwich == 0 && zeros == 0) ||
                (sandwich == 1 && ones == 0)
            ) break;

            if (sandwich == 0) zeros--;
            else ones--;
        }

        return zeros + ones;
    }
}