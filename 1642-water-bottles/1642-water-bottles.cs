public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int emptyBottles = 0, result = 0;

        while (numBottles > 0) {
            result += numBottles;
            emptyBottles += numBottles;
            numBottles = emptyBottles / numExchange;
            emptyBottles %= numExchange;
        }

        return result;
    }
}