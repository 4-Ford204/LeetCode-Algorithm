using System.Text.RegularExpressions;

public class Solution {
    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive) {
        return code.Zip(businessLine, isActive)
            .Where(x =>
                Regex.IsMatch(x.First, "^[a-zA-Z0-9_]+$") &&
                x.Second is "electronics" or "grocery" or "pharmacy" or "restaurant" &&
                x.Third
            )
            .OrderBy(x => x.Second)
            .ThenBy(x => x.First, StringComparer.Ordinal)
            .Select(x => x.First)
            .ToArray();
    }
}