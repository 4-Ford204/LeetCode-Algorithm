public class Solution {
    public int MaxBottlesDrunk(int numBottles, int numExchange) {
        int emptyBottles = 0, result = 0;

        while (numBottles > 0) {
            result += numBottles;
            emptyBottles += numBottles;
            numBottles = 0;

            if (emptyBottles >= numExchange) {
                numBottles += 1;
                emptyBottles -= numExchange++;
            }
        }

        return result;
    }
}