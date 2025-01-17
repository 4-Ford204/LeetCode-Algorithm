public class Solution {
    public bool DoesValidArrayExist(int[] derived) {
        return BruteForce(derived);
    }

    public bool Aggregate(int[] derived) => derived.Aggregate((x, y) => x ^ y) == 0;

    public bool BruteForce(int[] derived) {
        int xor = 0;

        foreach (var bit in derived) xor ^= bit;
        
        return xor == 0;
    }

    public bool Sum(int[] derived) => derived.Sum() % 2 == 0;
}