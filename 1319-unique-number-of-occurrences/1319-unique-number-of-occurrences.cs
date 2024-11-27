public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var frequency = new Dictionary<int, int>();
        var occurrences = new HashSet<int>();

        foreach (var num in arr) {
            if (frequency.ContainsKey(num)) frequency[num]++;
            else frequency.Add(num, 1);
        }

        foreach (var item in frequency)
            if (!occurrences.Add(item.Value)) return false;

        return true;
    }
}