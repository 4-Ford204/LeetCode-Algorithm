public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        foreach (var token in tokens) {
            if (token != "+" && token != "-" && token != "*" && token != "/")
                stack.Push(int.Parse(token));
            else {
                int b = stack.Pop(), a = stack.Pop();
                int result = 0;

                switch (token) {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        result = a / b;
                        break;
                }

                stack.Push(result);
            }
        }

        return stack.Pop();
    }
}