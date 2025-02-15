public class Solution {
    public int PunishmentNumber(int n) {
        int result = 0;
        var stack = new Stack<(int number, int target)>();

        for (var number = 1; number <= n; number++) {
            if (number == 1) result += 1;

            int square = number * number;
            bool canPartition = false;
            stack.Clear();
            stack.Push((square, number));

            while (stack.Count > 0)
            {
                var (currentNumber, currentTarget) = stack.Pop();

                for (var i = 10; i < currentNumber; i *= 10)
                {
                    var newNumber = currentNumber / i;
                    var newTarget = currentTarget - currentNumber % i;

                    if (newNumber == newTarget)
                    {
                        canPartition = true;
                        break;
                    }

                    stack.Push((newNumber, newTarget));
                }
            }

            if (canPartition) result += square;
        }

        return result;
    }
}