public class Solution {
    public int NumRabbits(int[] answers) {
        var colors = new Dictionary<int, int>();
        int result = answers.Length;

        foreach (var answer in answers) {
            if (colors.TryGetValue(answer, out var value) && value > 0) colors[answer]--;
            else colors[answer] = answer;
        }
    
        foreach (var rabbits in colors.Values) result += rabbits;

        return result;
    }
}