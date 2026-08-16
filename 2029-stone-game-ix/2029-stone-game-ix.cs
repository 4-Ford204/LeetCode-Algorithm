public class Solution {
    public bool StoneGameIX(int[] stones) {
        int a = 0, b = 0, c = 0;

        foreach (var stone in stones) {
            switch (stone % 3) {
                case 0: a++; break;
                case 1: b++; break;
                case 2: c++; break;
            }
        }

        return a % 2 == 0 ? b >= 1 && c >= 1 : Math.Abs(b - c) > 2;
    }
}