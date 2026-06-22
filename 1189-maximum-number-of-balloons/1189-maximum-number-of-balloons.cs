public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int result = int.MaxValue;
        var arr = new int[5];

        foreach (var t in text) {
            switch (t) {
                case 'b': arr[0]++; break;
                case 'a': arr[1]++; break;
                case 'l': arr[2]++; break;
                case 'o': arr[3]++; break;
                case 'n': arr[4]++; break;
            }
        }

        arr[2] /= 2;
        arr[3] /= 2;

        foreach (var item in arr) {
            if (item < result) result = item;
        }

        return result;
    }
}