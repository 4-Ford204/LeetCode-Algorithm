public class Solution {
    public bool CheckIfExist(int[] arr) {
        for (int i = 0; i < arr.Length - 1; i++) {
            for (int j = i + 1; j < arr.Length; j++) {
                if (arr[i] * 2 == arr[j] || arr[i] == arr[j] * 2)
                    return true;
            }
        }

        return false;
    }
}