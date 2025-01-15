using System.Runtime.Intrinsics.X86;

public class Solution {
    public int MinimizeXor(int num1, int num2) {
        return BitManipulation(num1, num2);
    }

    public int FromOptimalToValid(int num1, int num2) {
        int result = num1, shift = 0;
        int currentBit = (int)Popcnt.PopCount((uint)result);
        int targetBit = (int)Popcnt.PopCount((uint)num2);

        while (currentBit < targetBit) {
            if ((result & (1 << shift)) == 0) {
                result |= 1 << shift;
                currentBit++;
            }

            shift++;
        }

        while (currentBit > targetBit) {
            if ((result & (1 << shift)) != 0) {
                result &= ~(1 << shift);
                currentBit--;
            }

            shift++;
        }

        return result;
    }

    public int BitManipulation(int num1, int num2) {
        int k = (int)(Popcnt.PopCount((uint)num2) - Popcnt.PopCount((uint)num1));

        if (k >= 0) for (int i = 0; i < k; i++) num1 |= num1 + 1;
        else for (int i = 0; i < -k; i++) num1 &= num1 - 1;

        return num1;
    }
}