public class Solution {
    public int MaximumSwap(int num) {
        char[] numArr = num.ToString().ToCharArray();
        int n = numArr.Length;
        int[] maxRightIndex = new int[n];
        maxRightIndex[n - 1] = n - 1;

        for (int i = n - 2; i >= 0; i--) {
            maxRightIndex[i] = 
                numArr[i] > numArr[maxRightIndex[i + 1]] ? 
                i : 
                maxRightIndex[i + 1];
        }

        for (int i = 0; i < n; i++) {
            if (numArr[i] < numArr[maxRightIndex[i]]) {
                (numArr[i], numArr[maxRightIndex[i]]) = (numArr[maxRightIndex[i]], numArr[i]);
                return int.Parse(new string(numArr));
            }
        }

        return num;
    }
}