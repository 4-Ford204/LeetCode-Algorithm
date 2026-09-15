public class Solution {
    public int CountSpecialIntegers(int[] nums) {
        int previous = 0;
        var contiguous = new HashSet<int>();
        var separated = new HashSet<int>();

        foreach (var num in nums) {
            if (num != previous) {
                if (!contiguous.Contains(num))
                    contiguous.Add(num);
                else
                    separated.Add(num);
            }

            previous = num;
        }

        return contiguous.Count - separated.Count;
    }
}