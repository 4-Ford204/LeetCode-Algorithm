public class NumArray {
    private int[] SegmentTree = new int[150_000];
    private int[] Numbers;

    public NumArray(int[] nums) {
        Numbers = nums;
        Build(1, 0, Numbers.Length - 1);
    }
    
    public void Update(int index, int val) {
        Numbers[index] = val;
        Update(1, 0, Numbers.Length - 1, index, val);
    }
    
    public int SumRange(int left, int right) {
        return Query(1, 0, Numbers.Length - 1, left, right);
    }

    private void Build(int i, int left, int right) {
        if (left == right) {
            SegmentTree[i] = Numbers[left];
            return;
        }
        
        int middle = (left + right) >> 1;
        Build(i << 1, left, middle);
        Build(i << 1 | 1, middle + 1, right);
        SegmentTree[i] = SegmentTree[i << 1] + SegmentTree[i << 1 | 1];
    }

    private void Update(int i, int left, int right, int position, int value) {
        if (left == right) {
            SegmentTree[i] = value;
            return;
        }

        int middle = (left + right) >> 1;

        if (position <= middle)
            Update(i << 1, left, middle, position, value);
        else
            Update(i << 1 | 1, middle + 1, right, position, value);

        SegmentTree[i] = SegmentTree[i << 1] + SegmentTree[i << 1 | 1];
    }

    private int Query(int i, int left, int right, int queryLeft, int queryRight) {
        if (queryLeft > right || queryRight < left)
            return 0;
            
        if (queryLeft <= left && queryRight >= right)
            return SegmentTree[i];
        
        int middle = (left + right) >> 1;
        return
            Query(i << 1, left, middle, queryLeft, queryRight) +
            Query(i << 1 | 1, middle + 1, right, queryLeft, queryRight);
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */