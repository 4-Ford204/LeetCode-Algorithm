public class Solution {
    public int CountCollisions(string directions) {
        int result = 0;
        directions = directions.TrimStart('L').TrimEnd('R');
        
        foreach (var direction in directions) {
            if (direction != 'S') result++;
        }

        return result;
    }
}
