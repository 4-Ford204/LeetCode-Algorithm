public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int result = neededTime[0], maxTime = neededTime[0];
        
        for (int i = 1; i < colors.Length; i++) {
            var currentTime = neededTime[i];
            result += currentTime;

            if (colors[i] != colors[i - 1]) {
                result -= maxTime;
                maxTime = currentTime;
            }
            else maxTime = Math.Max(maxTime, currentTime);
        }

        return result - maxTime;
    }
}