public class Solution {
    public int FindChampion(int n, int[][] edges) {
        int[] degree = new int[n]; 
        int count = 0;
        int champion = -1;

        for (int i = 0; i < edges.Length; i++) degree[edges[i][1]]++;

        for (int i = 0; i < n; i++) {
            if (degree[i] == 0) {
                champion = i;
                count++;
            }

            if (count >= 2) break;
        }

        return count == 1 ? champion : -1;
    }
}