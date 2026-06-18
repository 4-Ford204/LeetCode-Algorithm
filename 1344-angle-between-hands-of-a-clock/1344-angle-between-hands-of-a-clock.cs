public class Solution {
    public double AngleClock(int hour, int minutes) {
        var min = minutes * 6.0;
        var h = (hour % 12) * 30.0 + minutes * 0.5;
        var result = Math.Abs(min - h);

        return Math.Min(result, 360 - result);
    }
}