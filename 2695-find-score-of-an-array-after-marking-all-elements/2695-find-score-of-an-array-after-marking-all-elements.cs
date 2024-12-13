public class Solution {
    public long FindScore(int[] nums) {
        int n = nums.Length;
        long score = 0;

        for (int left = 0, right = 0; right < n; right += 2) {
            left = right;

            while (right + 1 < n && nums[right] > nums[right + 1]) right++;

            for (int i = right; i >= left; i -= 2) score += nums[i];
        }

        return score;
    }

    private long Heap(int[] nums) {
        int n = nums.Length;
        (int index, int value)[] heap = new (int, int)[n];
        bool[] marked = new bool[n];
        long score = 0;

        for (int i = 0; i < n; i++) heap[i] = (i, nums[i]);

        Array.Sort(heap, (x, y) => 
            x.value == y.value ? x.index.CompareTo(y.index) : x.value.CompareTo(y.value)
        );

        for (int i = 0; i < n; i++) {
            var (index, value) = heap[i];

            if (marked[index]) continue;
            else {
                score += value;
                marked[index] = true;
                if (index > 0) marked[index - 1] = true;
                if (index < n - 1) marked[index + 1] = true;
            }
        }

        return score;
    }
}