public class ProductOfNumbers {
    private List<int> Numbers { get; set; }

    public ProductOfNumbers() {
        Numbers = new List<int>();
    }
    
    public void Add(int num) {
        int n = Numbers.Count;

        if (num == 0) {
            Numbers.Clear();
            return;
        }

        if (n == 0) Numbers.Add(num);
        else Numbers.Add(num * Numbers[n - 1]);
    }
    
    public int GetProduct(int k) { 
        int n = Numbers.Count;

        return 
            n < k ? 0 : 
            n == k ? Numbers[k - 1] : 
            Numbers[n - 1] / Numbers[n - k - 1];
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */