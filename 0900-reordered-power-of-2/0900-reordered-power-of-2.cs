public class Solution {
    public bool ReorderedPowerOf2(int n) {
        var counter = new Dictionary<int, int>();

        while (n > 0) {
            var num = n % 10;

            if (!counter.ContainsKey(num)) counter[num] = 0;
            counter[num]++;

            n /= 10;
        }

        return GetPermutation(new List<int>(), counter.Sum(x => x.Value), counter);
    }

    private bool GetPermutation(List<int> current, int n, Dictionary<int, int> counter) {
        if (current.Count == n && current[0] != 0) {
            var number = 0;

            foreach (var num in current) {
                number = number * 10 + num;
            }

            return (number & (number - 1)) == 0;
        }

        foreach (var (num, count) in counter) {
            if (count == 0) continue;

            counter[num]--;
            current.Add(num);

            if (GetPermutation(current, n, counter)) return true;

            current.RemoveAt(current.Count - 1);
            counter[num]++;
        }

        return false;
    }
}