public class Solution {
    public int RobotSim(int[] commands, int[][] obstacles) {
        int x = 0, y = 0, index = 0, result = 0;
        var direction = new int[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
        var hashset = new HashSet<(int, int)>();

        foreach (var obstacle in obstacles) hashset.Add((obstacle[0], obstacle[1]));

        foreach (var command in commands) {
            if (command == -1) index = (index + 1) % 4;
            else if (command == -2) index = ((index - 1) + 4) % 4;
            else {
                for (int i = 0; i < command; i++) {
                    var nextX = x + direction[index, 0];
                    var nextY = y + direction[index, 1];

                    if (hashset.Contains((nextX, nextY))) break;
                    
                    x = nextX;
                    y = nextY;
                    result = Math.Max(result, x * x + y * y);
                }
            }
        }

        return result;
    }
}