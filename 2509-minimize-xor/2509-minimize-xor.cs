using System.Runtime.Intrinsics.X86;

public class Solution {
    public int MinimizeXor(int num1, int num2) {
        return FromOptimalToValid(num1, num2);
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
}