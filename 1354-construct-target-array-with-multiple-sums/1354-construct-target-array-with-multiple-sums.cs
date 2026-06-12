public class Solution {
    public bool IsPossible(int[] target) {
        var sum = 0L;
        var heap = new PriorityQueue<long, long>(
            Comparer<long>.Create((a, b) => b.CompareTo(a))
        );

        foreach (var num in target) {
            sum += num;
            heap.Enqueue(num, num);
        }

        while (true) {
            var biggest = heap.Dequeue();
            sum -= biggest;

            if (biggest == 1 || sum == 1) return true;
            
            if (biggest < sum || sum == 0 || biggest % sum == 0) return false;

            var current = biggest % sum;

            if (current == biggest) return false;

            heap.Enqueue(current, current);
            sum += current;
        }
    }
}