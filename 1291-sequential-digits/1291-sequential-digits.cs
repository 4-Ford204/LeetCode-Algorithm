public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        var result = new List<int>();
        string digit = "123456789";
        int min = low.ToString().Length;
        int max = high.ToString().Length;

        for (int i = min; i <= max; i++) {
            for (int start = 0; start + i <= 9; start++){
                int num = int.Parse(digit.Substring(start, i));
                if (num >= low && num <= high) result.Add(num);
            }
        }

        return result;
    }
}