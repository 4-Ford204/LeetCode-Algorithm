public class Solution {
    public int MaxEqualRowsAfterFlips(int[][] matrix) {
        Dictionary<string, int> rowValues = new Dictionary<string, int>();

        foreach (var row in matrix) {
            int firstBit = row[0];
            StringBuilder builder = new StringBuilder();

            foreach (var bit in row) builder.Append(bit ^ firstBit);

            string key = builder.ToString();
            if (rowValues.ContainsKey(key)) rowValues[key]++;
            else rowValues.Add(key, 1);
        }

        int result = 0;
        foreach (var kvp in rowValues) result = Math.Max(result, kvp.Value);

        return result;
    }
}