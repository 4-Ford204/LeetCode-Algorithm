public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        var builder = new StringBuilder();
        var fraction = new Dictionary<long, int>();

        if (numerator == 0) return "0";

        if ((numerator < 0) ^ (denominator < 0)) builder.Append("-");

        long num = Math.Abs((long)numerator);
        long den = Math.Abs((long)denominator);

        builder.Append((num / den).ToString());

        long remain = num % den;

        if (remain != 0) {
            builder.Append(".");

            while (remain != 0) {
                if (fraction.ContainsKey(remain)) {
                    builder.Insert(fraction[remain], "(");
                    builder.Append(")");
                    break;
                }

                fraction[remain] = builder.Length;
                remain *= 10;
                builder.Append(remain / den);
                remain %= den;
            }
        } 

        return builder.ToString();
    }
}