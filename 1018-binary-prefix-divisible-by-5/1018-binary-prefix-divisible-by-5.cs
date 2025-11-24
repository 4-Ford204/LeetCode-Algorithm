public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        int current = 0;
        var result = new List<bool>();

        foreach (var num in nums) {
            current = ((current << 1) + num) % 5;
            result.Add(current == 0);
        }

        return result;
    }
}