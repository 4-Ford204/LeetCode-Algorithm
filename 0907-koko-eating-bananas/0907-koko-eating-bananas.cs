public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max = piles.Max();

        if (piles.Length == h) return max;
        else {
            int left = 1;
            int right = (int)Math.Ceiling((double)max / (h / piles.Length));
            int min = right;

            while (left <= right) {
                int middle = left + (right - left) / 2;
                long hour = 0;

                foreach (int pile in piles)
                    hour += (long)Math.Ceiling((double)pile / middle);
                
                if (hour <= h) {
                    min = middle;
                    right = middle - 1;
                } else
                    left = middle + 1;
            }

            return min;
        }
    }
}