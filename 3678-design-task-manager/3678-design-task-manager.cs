public class TaskManager {
    public Dictionary<int, (int, int)> task = new();
    PriorityQueue<int, (int, int)> user = new();

    public TaskManager(IList<IList<int>> tasks) {
        foreach (var item in tasks) {
            task.Add(item[1], (item[0], item[2]));
            user.Enqueue(item[0], (-item[2], -item[1]));
        }
    }
    
    public void Add(int userId, int taskId, int priority) {
        task.Add(taskId, (userId, priority));
        user.Enqueue(userId, (-priority, -taskId));
    }
    
    public void Edit(int taskId, int newPriority) {
        var (userId, priority) = task[taskId];
        task[taskId] = (userId, newPriority);
        user.Enqueue(userId, (-newPriority, -taskId));
    }
    
    public void Rmv(int taskId) {
        task.Remove(taskId);
    }
    
    public int ExecTop() {
        int userId = -1;
        (int, int) priority;
        bool check = false;

        while (user.TryDequeue(out userId, out priority)) {
            if (!task.ContainsKey(-priority.Item2)) continue;
            if (task[-priority.Item2].Item2 == -priority.Item1 && userId == task[-priority.Item2].Item1) {
                check = true;
                break;
            }
        }

        task.Remove(-priority.Item2);

        return check ? userId : -1;
    }
}

/**
 * Your TaskManager object will be instantiated and called as such:
 * TaskManager obj = new TaskManager(tasks);
 * obj.Add(userId,taskId,priority);
 * obj.Edit(taskId,newPriority);
 * obj.Rmv(taskId);
 * int param_4 = obj.ExecTop();
 */