public class RandomizedSet {
    private Dictionary<int, int> map;
    private List<int> set;
    private Random random;

    public RandomizedSet() {
        this.map = new Dictionary<int, int>();
        this.set = new List<int>();
        this.random = new Random(); 
    }
    
    public bool Insert(int val) {
        if (map.ContainsKey(val)) return false;

        set.Add(val);
        map[val] = set.Count - 1;

        return true;
    }
    
    public bool Remove(int val) {
        if (!map.ContainsKey(val)) return false;

        map[set[set.Count - 1]] = map[val];
        (set[set.Count - 1], set[map[val]]) = (set[map[val]], set[set.Count - 1]);
        map.Remove(val);
        set.RemoveAt(set.Count - 1);

        return true;
    }
    
    public int GetRandom() {
        return set[random.Next(0, set.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */