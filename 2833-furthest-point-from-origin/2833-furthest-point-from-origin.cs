public class Solution {
    public int FurthestDistanceFromOrigin(string moves) {
        int n = moves.Length;
        var arr = new int[3];

        foreach (var move in moves) {
            int index = move switch {
                'L' => 0,
                'R' => 1,
                _ => 2
            };
            arr[index]++;
        }

        return Math.Abs(arr[0] - arr[1]) + arr[2];
    }
}