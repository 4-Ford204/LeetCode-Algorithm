public class Solution {
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies) {
        int n = recipes.Length;
        var availableSupplies = new HashSet<string>();
        var recipeToIndex = new Dictionary<string, int>();
        var dependencyGraph = new Dictionary<string, List<string>>();
        var inDegree = new int[n];
        var queue = new Queue<int>();
        var result = new List<string>();

        foreach (var supply in supplies) availableSupplies.Add(supply);

        for (int i = 0; i < n; i++) recipeToIndex[recipes[i]] = i;

        for (int i = 0; i < n; i++) {
            foreach (var ingredient in ingredients[i]) {
                if (!availableSupplies.Contains(ingredient)) {
                    if (!dependencyGraph.ContainsKey(ingredient))
                        dependencyGraph[ingredient] = new List<string>();

                    dependencyGraph[ingredient].Add(recipes[i]);
                    inDegree[i]++;
                }
            }
        }

        for (int i = 0; i < n; i++) {
            if (inDegree[i] == 0) queue.Enqueue(i);
        }

        while (queue.Count > 0) {
            string recipe = recipes[queue.Dequeue()];
            result.Add(recipe);

            if (dependencyGraph.ContainsKey(recipe)) {
                foreach (var dependentRecipe in dependencyGraph[recipe]) {
                    int index = recipeToIndex[dependentRecipe];
                    if (--inDegree[index] == 0) queue.Enqueue(index);
                }
            }
        }

        return result;
    }
}