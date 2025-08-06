public class Solution {
    private int[] SegmentTree = new int[400_007];
    private int[] Baskets;

    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        Array.Fill(SegmentTree, int.MinValue);
        Baskets = baskets;
        int n = Baskets.Length, count = 0;

        if (n == 0) return fruits.Length;

        Build(1, 0, n - 1);

        for (int i = 0; i < fruits.Length; i++) {
            int left = 0, right = n - 1, result = -1;

            while (left <= right) {
                int middle = (left + right) >> 1;

                if (Query(1, 0, n - 1, 0, middle) >= fruits[i]) {
                    result = middle;
                    right = middle - 1;
                } else 
                    left = middle + 1;
            }

            if (result != -1 && Baskets[result] >= fruits[i])
                Update(1, 0, n - 1, result, int.MinValue);
            else
                count++;
        }

        return count;
    }

    private void Build(int index, int left, int right) {
        if (left == right) {
            SegmentTree[index] = Baskets[left];
            return;
        }

        int middle = (left + right) >> 1;
        Build(index << 1, left, middle);
        Build(index << 1 | 1, middle + 1, right);
        SegmentTree[index] = Math.Max(SegmentTree[index << 1], SegmentTree[index << 1 | 1]);
    }

    private int Query(int index, int left, int right, int queryLeft, int queryRight) {
        if (queryLeft > right || queryRight < left)
            return int.MinValue;

        if (queryLeft <= left && queryRight >= right)
            return SegmentTree[index];

        int middle = (left + right) >> 1;
        return Math.Max(
            Query(index << 1, left, middle, queryLeft, queryRight),
            Query(index << 1 | 1, middle + 1, right, queryLeft, queryRight)
        );
    }

    private void Update(int index, int left, int right, int position, int value) {
        if (left == right) {
            SegmentTree[index] = value;
            return;
        }

        int middle = (left + right) >> 1;

        if (position <= middle)
            Update(index << 1, left, middle, position, value);
        else
            Update(index << 1 | 1, middle + 1, right, position, value);

        SegmentTree[index] = Math.Max(SegmentTree[index << 1], SegmentTree[index << 1 | 1]);
    }
}
