public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        List<int> stack = new List<int>();

        for (int i = 0; i < asteroids.Length; i++) {
            int asteroid = asteroids[i];

            while (stack.Count > 0 && stack[stack.Count - 1] > 0 && asteroid < 0) {
                int collision = stack[stack.Count - 1] + asteroid;

                if (collision <= 0) stack.RemoveAt(stack.Count - 1);
                if (collision >= 0) asteroid = 0;
            }
            
            if (asteroid != 0) stack.Add(asteroid);
        }

        return stack.ToArray();
    }
}