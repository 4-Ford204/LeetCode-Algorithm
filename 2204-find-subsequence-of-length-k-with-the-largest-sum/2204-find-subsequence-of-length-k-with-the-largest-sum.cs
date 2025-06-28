public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
        var heapValue = new List<(int index, int value)>();
        var heapIndex = new List<(int index, int value)>();
        var result = new int[k];

        for (int i = 0; i < nums.Length; i++) heapValue.Add((i, nums[i]));
        heapValue.Sort((a, b) => b.value.CompareTo(a.value));

        for (int i = 0; i < k; i++) heapIndex.Add(heapValue[i]);
        heapIndex.Sort((a, b) => a.index.CompareTo(b.index));

        for (int i = 0; i < k; i++) result[i] = heapIndex[i].value;

        return result;
    }

    private int[] PriorityQueue(int[] nums, int k) {
        var heapValue = new PriorityQueue<(int value, int index), int>();
        var heapIndex = new PriorityQueue<int, int>();
        int[] result = new int[k];

        for (int i = 0; i < nums.Length; i++) heapValue.Enqueue((nums[i], i), -nums[i]);

        for (int i = 0; i < k; i++) {
            var (value, index) = heapValue.Dequeue();
            heapIndex.Enqueue(value, index);
        }

        for (int i = 0; i < k; i++) result[i] = heapIndex.Dequeue();

        return result;
    }
}