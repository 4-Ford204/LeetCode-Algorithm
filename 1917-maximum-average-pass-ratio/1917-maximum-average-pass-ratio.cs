public class Solution {
    public double MaxAverageRatio(int[][] classes, int extraStudents) {
        PriorityQueue<(int, int), double> heap = new PriorityQueue<(int, int), double>();
        double totalRatio = 0;

        foreach (var @class in classes) {
            int pass = @class[0], total = @class[1];
            double current = (double)pass / total;
            double next = (double)(pass + 1) / (total + 1);
            heap.Enqueue((pass, total), -(next - current));
        }

        while (extraStudents > 0) {
            var (pass, total) = heap.Dequeue();
            double current = (double)(pass + 1) / (total + 1);
            double next = (double)(pass + 2) / (total + 2);
            heap.Enqueue((pass + 1, total + 1), -(next - current));
            extraStudents--;
        }

        while (heap.Count > 0) {
            var (pass, total) = heap.Dequeue();
            totalRatio += (double)pass / total;
        }

        return totalRatio / classes.Length;
    }
}