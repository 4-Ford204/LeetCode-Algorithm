public class NumberContainers {

    private Dictionary<int, int> Indexes;
    private Dictionary<int, PriorityQueue<int, int>>  Numbers;

    public NumberContainers() {
        Indexes = new Dictionary<int, int>();
        Numbers = new Dictionary<int, PriorityQueue<int, int>>();
    }
    
    public void Change(int index, int number) {
        if (Indexes.ContainsKey(index)) Indexes[index] = number;
        else Indexes.Add(index, number);

        if (Numbers.ContainsKey(number)) Numbers[number].Enqueue(index, index);
        else {
            var heap = new PriorityQueue<int, int>();
            heap.Enqueue(index, index);
            Numbers.Add(number, heap);
        }
    }
    
    public int Find(int number) {
        if (Numbers.ContainsKey(number)) {
            while (Numbers[number].Count > 0) {
                int index = Numbers[number].Peek();

                if (Indexes[index] == number) return index;

                Numbers[number].Dequeue();
            }
        }

        return -1;
    }
}

/**
 * Your NumberContainers object will be instantiated and called as such:
 * NumberContainers obj = new NumberContainers();
 * obj.Change(index,number);
 * int param_2 = obj.Find(number);
 */