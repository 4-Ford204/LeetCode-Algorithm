public class Solution {
    public IList<string> RemoveSubfolders(string[] folder) {
        Array.Sort(folder);
        var result = new List<string>();
        result.Add(folder[0]);

        for (int i = 1; i < folder.Length; i++)
        {
            int current = folder[i].Length;
            int previous = result[^1].Length;

            if (
                previous >= current ||
                !result[^1].Equals(folder[i].Substring(0, previous)) ||
                folder[i][previous] != '/'
            ) result.Add(folder[i]);
        }
        
        return result;
    }
}