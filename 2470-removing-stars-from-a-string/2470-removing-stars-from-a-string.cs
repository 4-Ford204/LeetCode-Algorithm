public class Solution {
    public string RemoveStars(string s) {
        StringBuilder builder = new StringBuilder();
        int starCount = 0;

        for (var i = s.Length - 1; i >= 0; i--) {
            if (s[i] == '*') starCount++;
            else {
                if (starCount == 0) builder.Append(s[i]);
                else starCount--;
            }
        }
        
        return new string(builder.ToString().Reverse().ToArray());
    }
}