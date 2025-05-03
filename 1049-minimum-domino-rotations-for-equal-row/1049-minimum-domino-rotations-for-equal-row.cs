public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        int MinRotation(int target) {
            int topRotation = 0, bottomRotation = 0;

            for (int i = 0; i < tops.Length; i++) {
                int top = tops[i], bottom = bottoms[i];

                if (top != target && bottom != target) return int.MaxValue;
                else if (top != target) topRotation++;
                else if (bottom != target) bottomRotation++;
            }

            return Math.Min(topRotation, bottomRotation);
        }

        int result = int.MaxValue;
        int[] targets = new int[] { tops[0], bottoms[0] };

        foreach (var target in targets)
            result = Math.Min(result, MinRotation(target));

        return result == int.MaxValue ? -1 : result;
    } 
}