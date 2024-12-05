public class SmallestInfiniteSet {
    int Smallest { get; set; }
    int[] RemoveItems { get; set; }

    public SmallestInfiniteSet() {
        Smallest = 1;
        RemoveItems = new int[1001];
    }
    
    public int PopSmallest() {
        var smallest = Smallest;
        RemoveItems[smallest] = 1;

        for (int i = smallest + 1; i < RemoveItems.Length; i++) {
            if (RemoveItems[i] == 0) {
                Smallest = i;
                break;
            }
        }
        
        return smallest;
    }
    
    public void AddBack(int num) {
        if (RemoveItems[num] == 1) {
            RemoveItems[num] = 0;    
            if (num < Smallest) Smallest = num;
        }
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */