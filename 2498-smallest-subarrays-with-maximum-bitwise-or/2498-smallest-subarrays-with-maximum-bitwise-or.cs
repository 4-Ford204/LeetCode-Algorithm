public class Solution {
    public int[] SmallestSubarrays(int[] nums) {
        int n = nums.Length;
        int[] position = new int[31], answer = new int[n];

        Array.Fill(position, -1);

        for (int i = n - 1; i >= 0; i--) {
            int j = i;

            for (int bit = 0; bit < 31; bit++) {
                if ((nums[i] & (1 << bit)) == 0) {
                    if (position[bit] != -1)
                        j = Math.Max(j, position[bit]);
                } else 
                    position[bit] = i;
            }

            answer[i] = j - i + 1;
        }

        return answer;
    }
}