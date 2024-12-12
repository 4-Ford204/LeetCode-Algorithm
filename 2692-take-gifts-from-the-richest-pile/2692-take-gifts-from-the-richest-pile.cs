public class Solution {
    public long PickGifts(int[] gifts, int k) { 
        int n = gifts.Length;
        long result = 0;
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
    
        foreach (var gift in gifts) {
            result += gift;
            heap.Enqueue(gift, -gift);
        }

        while (k-- > 0) {
            int gift = heap.Dequeue();
            int giftSquareRoot = (int)Math.Sqrt(gift);

            result -= gift - giftSquareRoot;
            heap.Enqueue(giftSquareRoot, -giftSquareRoot);
        }

        return result;
    }
}