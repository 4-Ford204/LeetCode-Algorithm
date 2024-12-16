public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        while (k-- > 0) {
            int index = 0;

            for (int i = 1; i < nums.Length; i++) {
                if (nums[index] > nums[i]) index = i;
            }

            nums[index] *= multiplier;
        }

        return nums;
    }

    private int[] Heap(int[] nums, int k, int multiplier) {
        var heap = new PriorityQueue<int, (int, int)>(
            Comparer<(int value, int index)>.Create((x, y) =>
                x.value == y.value ? x.index.CompareTo(y.index) : x.value.CompareTo(y.value) 
            )
        );

        for (int i = 0; i < nums.Length; i++) 
            heap.Enqueue(i, (nums[i], i));
        
        while (k-- > 0) {
            int index = heap.Dequeue();
            nums[index] *= multiplier;
            heap.Enqueue(index, (nums[index], index));
        }

        return nums;
    }
}