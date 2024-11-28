public class RecentCounter {
    public Queue<int> Requests;

    public RecentCounter() {
        Requests = new Queue<int>();
    }
    
    public int Ping(int t) {
        Requests.Enqueue(t);
        while (Requests.Peek() < (t - 3000)) Requests.Dequeue();
        return Requests.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */