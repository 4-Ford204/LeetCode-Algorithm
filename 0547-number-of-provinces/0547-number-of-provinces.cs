public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int n = isConnected.Length;
        int provinceNumber = 0;
        bool[] visit = new bool[n];

        for (int i = 0; i < n; i++) {
            if (!visit[i]) {
                provinceNumber++;
                visit[i] = true;
                DFS(i, isConnected, visit);
            }
        }

        return provinceNumber;
    }

    private void DFS(int city, int[][] isConnected, bool[] visit) {
        for (int i = 0; i < isConnected.Length; i++) {
            if (isConnected[city][i] == 1 && !visit[i]) {
                visit[i] = true;
                DFS(i, isConnected, visit);
            } 
        }
    }
}