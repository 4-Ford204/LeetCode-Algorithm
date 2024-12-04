public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        bool[] seen = new bool[rooms.Count()];
        seen[0] = true;
        Stack<int> stack = new Stack<int>();
        stack.Push(0);

        while (stack.Count() != 0) {
            int room = stack.Pop();
            
            foreach (var key in rooms[room]) {
                if (!seen[key]) {
                    seen[key] = true;
                    stack.Push(key);
                }
            }
        }

        foreach (var visited in seen) {
            if (!visited) return false;
        }

        return true;
    }
}