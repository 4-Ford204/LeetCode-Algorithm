public class Solution {
    public int NumTilePossibilities(string tiles) {
        return OptimizedRecursion(tiles);
    }

    public int Recursion(string tiles) {
        HashSet<string> hashset = new HashSet<string>();
        int length = tiles.Length;
        bool[] generated = new bool[length];

        GenerateSequences("");

        void GenerateSequences(string current) {
            hashset.Add(current);

            for (int i = 0; i < length; i++) {
                if (!generated[i]) {
                    generated[i] = true;
                    GenerateSequences(current + tiles[i]);
                    generated[i] = false;
                }
            }
        }

        return hashset.Count - 1;
    }

    public int OptimizedRecursion(string tiles) {
        int[] character = new int[26];

        foreach (var tile in tiles) character[tile - 'A']++;

        int FindSequences() {
            int total = 0;

            for (int i = 0; i < 26; i++) {
                if (character[i] != 0) {
                    total++;
                    character[i]--;
                    total += FindSequences();
                    character[i]++;
                }
            }

            return total;
        }

        return FindSequences();
    }
}