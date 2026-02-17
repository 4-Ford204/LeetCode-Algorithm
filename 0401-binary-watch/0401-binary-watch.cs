public class Solution {
    public IList<string> ReadBinaryWatch(int turnedOn) {
        var result = new List<string>();

        for (int i = 0; i < 720; i++) {
            int hour = i / 60;
            int minute = i % 60;

            if (CountBit(hour) + CountBit(minute) == turnedOn)
                result.Add($"{hour}:{minute:00}");
        }
        
        return result;
    }

    private int CountBit(int num) {
        var result = 0;

        while (num > 0) {
            result++;
            num &= num - 1;
        }

        return result;
    }
}