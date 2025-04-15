public class FenwickTree {
    private int[] _tree;

    public FenwickTree(int size) {
        _tree = new int[size + 1];
    }

    public void Update(int index, int delta) {
        index++;

        while (index < _tree.Length) {
            _tree[index] += delta;
            index += index & -index;
        }
    }

    public int Query(int index) {
        int result = 0;
        index++;

        while (index > 0) {
            result += _tree[index];
            index -= index & -index;
        }

        return result;
    }
}

public class Solution {
    public long GoodTriplets(int[] nums1, int[] nums2) {
        int n = nums1.Length;
        int[] pos2 = new int[n], reversedIndexMapping = new int[n];
        FenwickTree tree = new FenwickTree(n);
        long result = 0;

        for (int i = 0; i < n; i++) pos2[nums2[i]] = i;

        for (int i = 0; i < n; i++) reversedIndexMapping[pos2[nums1[i]]] = i;

        for (int index2 = 0; index2 < n; index2++) {
            int index1 = reversedIndexMapping[index2];
            int left = tree.Query(index1);
            tree.Update(index1, 1);
            int right = (n - 1 - index1) - (index2 - left);
            result += (long)left * right;
        }

        return result;
    }
}