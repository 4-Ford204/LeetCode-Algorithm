public class Solution {
    public IList<string> LetterCombinations(string digits) {
        Dictionary<char, string> map = new Dictionary<char, string>() {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };
        IList<string> result = Backtracking(map, digits, 0, new List<char>());

        return result[0] == "" ? [] : result;
    }

    private IList<string> Backtracking(Dictionary<char, string> map, string digits, int index, List<char> tracking) { 
        List<string> result = new List<string>();

        if (index >= digits.Length)
            return new List<string>() { new string(tracking.ToArray()) };

        foreach (var digit in map[digits[index]]) {
            tracking.Add(digit);
            result.AddRange(Backtracking(map, digits, index + 1, tracking));
            tracking.RemoveAt(tracking.Count - 1);
        }
        
        return result;
    }
}