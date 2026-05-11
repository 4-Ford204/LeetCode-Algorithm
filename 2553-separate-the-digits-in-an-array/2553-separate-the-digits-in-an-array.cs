public class Solution {
    public int[] SeparateDigits(int[] nums) {
        int n = nums.Length;
        var answer = new List<int>();

        for (var i = n - 1; i >= 0; i--) {
            var num = nums[i];

            while (num > 0) {
                answer.Add(num % 10);
                num /= 10;
            }
        }

        answer.Reverse();
        return answer.ToArray();
    }
}