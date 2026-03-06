public class Solution {
    public int[] ExclusiveTime(int n, IList<string> logs) {
        var result = new int[n];
        var stack = new Stack<(int id, int start)>();

        foreach (var item in logs) {
            var current = item.Split(':');
            int id = int.Parse(current[0]);
            int time = int.Parse(current[2]);

            if (current[1] == "start") {
                if (stack.Count > 0) {
                    var previous = stack.Peek();
                    result[previous.id] += time - previous.start;
                }

                stack.Push((id, time));
            } else {
                var previous = stack.Pop();
                result[previous.id] += time - previous.start + 1;

                if (stack.Count > 0) {
                    var next = stack.Pop();
                    stack.Push((next.id, time + 1));
                }
            }
        }

        return result;
    }
}