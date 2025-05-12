public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        int[] freq = new int[10];
        List<int> result = new List<int>();

        foreach (var digit in digits) freq[digit]++;

        for (int i = 1; i < 10; i++) {
            if (freq[i] == 0) continue;
            freq[i]--;

            for (int j = 0; j < 10; j++) {
                if (freq[j] == 0) continue;
                freq[j]--;

                for (int k = 0; k < 10; k += 2) {
                    if (freq[k] == 0) continue;
                    result.Add(i * 100 + j * 10 + k);
                }

                freq[j]++;
            }

            freq[i]++;
        }

        return result.ToArray();
    }
}