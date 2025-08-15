public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int remainGas = 0, gasTank = 0, result = 0;

        for (int i = 0; i < gas.Length; i++) {
            int diff = gas[i] - cost[i];
            remainGas += diff;
            gasTank += diff;

            if (gasTank < 0) {
                gasTank = 0;
                result = i + 1;
            }
        }

        return remainGas >= 0 ? result : -1;
    }
}