public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int result = 0;
        
        foreach (var operation in operations)
            result += operation.Contains('+') ? 1 : -1;

        return result;
    }
}