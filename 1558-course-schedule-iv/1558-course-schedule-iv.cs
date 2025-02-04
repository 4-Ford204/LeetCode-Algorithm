public class Solution {
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {
        bool[,] isPrerequisite = new bool[numCourses, numCourses];
        List<bool> result = new List<bool>();

        foreach (var prerequisite in prerequisites) isPrerequisite[prerequisite[0], prerequisite[1]] = true;

        for (int course = 0; course < numCourses; course++) {
            for (int source = 0; source < numCourses; source++) {
                for (int destination = 0; destination < numCourses; destination++)
                    isPrerequisite[source, destination] = isPrerequisite[source, destination] || (isPrerequisite[source, course] && isPrerequisite[course, destination]);
            }
        }

        foreach (var query in queries) result.Add(isPrerequisite[query[0], query[1]]);

        return result;
    }
}