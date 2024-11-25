public class Solution {
    public int MaxArea(int[] height) {
        int leftPointer = 0;
        int rightPointer = height.Length - 1;
        int maxArea = 0;
        int area;

        while (leftPointer < rightPointer) {
            if (height[leftPointer] > height[rightPointer]) {
                area = height[rightPointer] * (rightPointer - leftPointer);
                rightPointer--;
            } else {
                area = height[leftPointer] * (rightPointer - leftPointer);
                leftPointer++;
            }

            maxArea = Math.Max(maxArea, area);
        }

        return maxArea;
    }
}