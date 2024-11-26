public class Solution {
    public int FindChampion(int n, int[][] edges) {
        HashSet<int> hashSet = new HashSet<int>(Enumerable.Range(0, n).ToArray());
        
        for (int i = 0; i < edges.Length; i++)
            hashSet.Remove(edges[i][1]);

        return hashSet.Count == 1 ? hashSet.Single() : -1;
    }
}