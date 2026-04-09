public class LRUCache {
    private class Node {
        public int Key;
        public int Value;
        public Node Previous;
        public Node Next;

        public Node(int key, int value) {
            Key = key;
            Value = value;
        }
    }
    
    private int Count { get; set; }
    private Dictionary<int, Node> Cache { get; set; }
    private Node head;
    private Node tail;

    public LRUCache(int capacity) {
        Count = capacity;
        Cache = new Dictionary<int, Node>();
        head = new Node(0, 0);
        tail = new Node(0, 0);
        head.Next = tail;
        tail.Previous = head;
    }
    
    private void Insert(Node node) {
        node.Next = head.Next;
        node.Previous = head;
        head.Next.Previous = node;
        head.Next = node;
    }

    private void Remove(Node node) {
        node.Previous.Next = node.Next;
        node.Next.Previous = node.Previous;
    }

    public int Get(int key) {
        if (!Cache.ContainsKey(key)) return -1;

        var node = Cache[key];
        Remove(node);
        Insert(node);

        return node.Value;
    }
    
    public void Put(int key, int value) {
        if (Cache.ContainsKey(key)) Remove(Cache[key]);

        var node = new Node(key, value);
        Cache[key] = node;
        Insert(node);

        if (Cache.Count > Count) {
            var remove = tail.Previous;
            Remove(remove);
            Cache.Remove(remove.Key);
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */