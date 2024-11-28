public class Solution {
    private int Index { get; set; } = 0;

    public string DecodeString(string s) {
        StringBuilder builder = new StringBuilder();

        while (Index < s.Length && s[Index] != ']') {
            if (char.IsLetter(s[Index])) builder.Append(s[Index++]);
            else {
                int number = 0;

                while (Index < s.Length && char.IsDigit(s[Index])) 
                    number = number * 10 + s[Index++] - '0';
                
                Index++;
                string decodeString = DecodeString(s);
                Index++;

                while (number-- > 0) builder.Append(decodeString);
            }
        }

        return builder.ToString();
    }
}