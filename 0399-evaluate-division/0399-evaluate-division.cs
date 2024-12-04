public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        var hashSet = new HashSet<string>();
        var graph = new Dictionary<string, Dictionary<string, double>>();
        var resultList = new Dictionary<string, double>();
        var calcEquation = new List<double>();

        for (int i = 0; i < equations.Count(); i++) {
            if (!graph.TryGetValue(equations[i][0], out resultList)) {
                graph.Add(
                    equations[i][0],
                    new Dictionary<string, double>() { 
                        { equations[i][1], values[i] } 
                    }
                );
            } else {
                resultList.Add(equations[i][1], values[i]);
            }

            if (!graph.TryGetValue(equations[i][1], out resultList)) {
                graph.Add(
                    equations[i][1],
                    new Dictionary<string, double>() { 
                        { equations[i][0], 1 / values[i] }
                    } 
                );
            } else {
                resultList.Add(equations[i][0], 1 / values[i]);
            }
        }
        
        foreach (var query in queries) 
            calcEquation.Add(DFS(query[0], query[1], graph, hashSet));

        return calcEquation.ToArray();
    }

    private double DFS(string dividend, string divisor, Dictionary<string, Dictionary<string, double>> graph, HashSet<string> hashSet) {
        if (!graph.TryGetValue(divisor, out var equations) || !graph.TryGetValue(dividend, out equations)) 
            return -1;
        else if (dividend == divisor) 
            return 1;
        else if (graph.TryGetValue(dividend, out equations) && equations.TryGetValue(divisor, out var quotient))
            return quotient;
        else {
            hashSet.Add(dividend);
            quotient = -1;

            foreach (var equation in equations) {
                if (!hashSet.Contains(equation.Key)) {
                    quotient = DFS(equation.Key, divisor, graph, hashSet);
                    
                    if (quotient != -1) {
                        quotient *= equation.Value;
                        break;
                    }
                }
            }

            hashSet.Remove(dividend);
            return quotient;
        }
    }
}