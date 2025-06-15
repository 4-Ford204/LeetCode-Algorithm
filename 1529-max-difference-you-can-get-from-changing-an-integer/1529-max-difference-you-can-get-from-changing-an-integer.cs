public class Solution {
    public int MaxDiff(int num) {
        string minNumber = num.ToString(), maxNumber = num.ToString();

        foreach (var digit in maxNumber) {
            if (digit != '9') {
                maxNumber = Replace(maxNumber, digit, '9');
                break;
            }
        }

        for (int i = 0; i < minNumber.Length; i++) {
            var digit = minNumber[i];

            if (i == 0) {
                if (digit != '1') {
                    minNumber = Replace(minNumber, digit, '1');
                    break;
                }
            } else {
                if (digit != '0' && digit != minNumber[0]) {
                    minNumber = Replace(minNumber, digit, '0');
                    break;
                }
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