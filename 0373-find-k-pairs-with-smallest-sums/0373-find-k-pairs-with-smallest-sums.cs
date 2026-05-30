public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        int n = nums1.Length, m = nums2.Length;
        var visited = new HashSet<(int, int)>();
        var heap = new PriorityQueue<(int i, int j), int>();
        var result = new List<IList<int>>();

        visited.Add((0, 0));
        heap.Enqueue((0, 0), nums1[0] + nums2[0]);

        while (k-- > 0 && heap.Count > 0) {
            var (i, j) = heap.Dequeue();
            result.Add(new List<int> { nums1[i], nums2[j] });

            if (i + 1 < n && !visited.Contains((i + 1, j))) {
                visited.Add((i + 1, j));
                heap.Enqueue((i + 1, j), nums1[i + 1] + nums2[j]);
            }

            if (j + 1 < m && !visited.Contains((i, j + 1))) {
                visited.Add((i, j + 1));
                heap.Enqueue((i, j + 1), nums1[i] + nums2[j + 1]);
            }
        }

        return result;
    }
}