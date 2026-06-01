public class Solution {
    public bool AsteroidsDestroyed(int mass, int[] asteroids) {
        long planet = mass;
        Array.Sort(asteroids);

        foreach (var asteroid in asteroids) {
            if (planet < asteroid) return false;
            planet += asteroid;
        }

        return true;
    }
}