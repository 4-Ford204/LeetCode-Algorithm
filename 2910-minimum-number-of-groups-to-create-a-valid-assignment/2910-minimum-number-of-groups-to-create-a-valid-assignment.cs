public class Solution {
    public int MinGroupsForValidAssignment(int[] balls) {
        int min = int.MaxValue;
        var map = new Dictionary<int, int>();

        foreach (var b in balls) {
            if (!map.ContainsKey(b)) map[b] = 0;
            map[b]++;
        }

        foreach (var count in map.Values) min = Math.Min(min, count);     

        while (min > 0) {
            int result = 0;

            foreach (int count in map.Values) {
                if((count / min) < (count % min)) {
                    result = 0;
                    break;
                }

                result += (count + min) / (min + 1);
            }

            if (result > 0) return result;

            min--;
        }

        return -1;
    }
}