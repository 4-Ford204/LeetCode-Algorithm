public class Solution {
    public int MinMaxDifference(int num) {
        string minNumber = num.ToString(), maxNumber = num.ToString();

        minNumber = Replace(minNumber, minNumber[0], '0');

        foreach (var digit in maxNumber) {
            if (digit != '9') {
                maxNumber = Replace(maxNumber, digit, '9');
                break;
            }
        }

        return int.Parse(maxNumber) - int.Parse(minNumber);
    }

    private string Replace(string number, char digit, char replacement) {
        StringBuilder builder = new StringBuilder();

        foreach (var num in number)
            builder.Append(num == digit ? replacement : num);

        return builder.ToString();
    }
}