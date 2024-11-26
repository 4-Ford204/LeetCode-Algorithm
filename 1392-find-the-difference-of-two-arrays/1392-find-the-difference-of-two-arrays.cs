public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> hashSet1 = new HashSet<int>(nums1);
        HashSet<int> hashSet2 = new HashSet<int>(nums2);
        List<int> result1 = new List<int>();
        List<int> result2 = new List<int>();

        foreach (int number in hashSet1)
            if (!hashSet2.Contains(number)) result1.Add(number);
        
        foreach (int number in hashSet2)
            if (!hashSet1.Contains(number)) result2.Add(number);
        
        return new List<IList<int>> { result1, result2 };
    }
}