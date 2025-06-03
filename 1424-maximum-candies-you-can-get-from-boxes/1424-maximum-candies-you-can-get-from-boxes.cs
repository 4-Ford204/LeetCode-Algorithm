public class Solution {
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes) {
        int n = status.Length, result = 0;
        bool[] hasBox = new bool[n];
        Queue<int> queue = new Queue<int>();
        
        foreach (var box in initialBoxes) {
            hasBox[box] = true;

            if (status[box] == 1)
                Execute(queue, status, candies, box, ref result);
        }

        while (queue.Count > 0) {
            var box = queue.Dequeue();

            foreach (var key in keys[box]) {
                if (status[key] == 0 && hasBox[key])
                    Execute(queue, status, candies, key, ref result);
                else 
                    status[key] = 1;
            }

            foreach (var containedBox in containedBoxes[box]) {
                hasBox[containedBox] = true;

                if (status[containedBox] == 1)
                    Execute(queue, status, candies, containedBox, ref result);
            }
        }

        return result;
    }

    private void Execute(Queue<int> queue, int[] status, int[] candies, int box, ref int result) {
        queue.Enqueue(box);
        status[box] = -1;
        result += candies[box];
    }
}