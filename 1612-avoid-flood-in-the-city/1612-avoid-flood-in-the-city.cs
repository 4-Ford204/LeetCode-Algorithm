public class Solution {
    public int[] AvoidFlood(int[] rains) {
        int n = rains.Length;
        var set = new SortedSet<int>();
        var dictionary = new Dictionary<int, int>();
        int[] ans = new int[n];
        
        Array.Fill(ans, 1);

        for (int i = 0; i < n; i++) {
            if (rains[i] == 0) set.Add(i);
            else {
                ans[i] = -1;

                if (dictionary.TryGetValue(rains[i], out var rainIndex)) {
                    int dryIndex = -1;

                    foreach (var index in set) {
                        if (index > rainIndex) {
                            dryIndex = index;
                            break;
                        }
                    }

                    if (dryIndex == -1) return Array.Empty<int>();

                    ans[dryIndex] = rains[i];
                    set.Remove(dryIndex);
                }

                dictionary[rains[i]] = i;
            }
        }

        return ans;
    }
}