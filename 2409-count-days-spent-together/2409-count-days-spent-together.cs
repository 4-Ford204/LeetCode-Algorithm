public class Solution {
    int[] prefix;

    public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob) {
        var monthDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        prefix = new int[12];

        for (int i = 1; i < 12; i++) prefix[i] = prefix[i - 1] + monthDays[i - 1];
        
        var maxArrive =  Math.Max(GetDate(arriveAlice), GetDate(arriveBob));
        var minLeave = Math.Min(GetDate(leaveAlice), GetDate(leaveBob));

        return Math.Max(0, minLeave - maxArrive + 1);
    }

    private int GetDate(string date) {
        var arr = date.Split('-');
        return prefix[int.Parse(arr[0]) - 1] + int.Parse(arr[1]);
    }
}