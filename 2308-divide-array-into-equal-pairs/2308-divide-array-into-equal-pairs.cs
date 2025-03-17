public class Solution {
    public bool DivideArray(int[] nums) {
        int[] frequency = new int[501];

        foreach (var num in nums) frequency[num]++;

        foreach (var time in frequency)
            if ((time & 1) != 0) return false;

        return true;
    }

    private bool HashSet(int[] nums) {
        HashSet<int> hashset = new HashSet<int>();

        foreach (var num in nums) {
            if (!hashset.Contains(num)) 
                hashset.Add(num);
            else
                hashset.Remove(num); 
        }

        return hashset.Count == 0;
    }

    private bool Dictionary(int[] nums) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        foreach (var num in nums) {
            if (!dictionary.ContainsKey(num))
                dictionary[num] = 1;
            else
                dictionary[num]++;
        }

        foreach (var kvp in dictionary)
            if (kvp.Value % 2 != 0) return false;
        
        return true;
    }
}