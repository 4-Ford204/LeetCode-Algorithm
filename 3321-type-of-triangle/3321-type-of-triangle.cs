public class Solution {
    public string TriangleType(int[] nums) {
        int x = nums[0], y = nums[1], z = nums[2];

        if (x + y <= z || x + z <= y || y + z <= x) return "none";
        else if (x == y && x == z) return "equilateral";
        else if (x == y || x == z || y == z) return "isosceles";
        else return "scalene";
    }
}