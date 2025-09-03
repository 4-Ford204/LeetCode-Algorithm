public class Solution {
    public double MaxAverageRatio(int[][] classes, int extraStudents) {
        int n  = classes.Length;
        var heap = new PriorityQueue<(int pass, int total), double>(n);

        foreach (var item in classes) {
            var (pass, total) = (item[0], item[1]);
            heap.Enqueue((pass, total), -NextRatio(pass, total));
        }

        while (extraStudents-- > 0) {
            var (pass, total) = heap.Dequeue();
            heap.Enqueue((++pass, ++total), -NextRatio(pass, total));
        }

        return heap.UnorderedItems.Sum(x => (double)x.Element.pass / x.Element.total) / n;
    }

    private double NextRatio(int pass, int total) {
        return (double)(pass + 1) / (total + 1) - (double)pass / total;
    }
}