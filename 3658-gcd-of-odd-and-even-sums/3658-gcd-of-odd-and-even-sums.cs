public class Solution {
    public int GcdOfOddEvenSums(int n) {
        int sumEven = (n + 1) * n, sumOdd = sumEven - n;
        return ComputeGCD(sumOdd, sumEven);
    }

    private int ComputeGCD(int num1, int num2) {
        while (num2 != 0) (num1, num2) = (num2, num1 % num2);
        return num1;
    }
}