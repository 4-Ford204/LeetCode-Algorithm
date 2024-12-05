public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) {
        long total = 0;
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        Array.Sort(nums2, nums1);

        for (int i = 1; i <= k; i++) {
            total += nums1[^i];
            heap.Enqueue(nums1[^i], nums1[^i]);
        }

        long result = total * nums2[^k];

        for (int i = k + 1; i <= nums1.Length; i++) {
            total += nums1[^i] - heap.EnqueueDequeue(nums1[^i], nums1[^i]);
            result = Math.Max(result, total * nums2[^i]);
        }

        return result;
    }
}