public class Solution {
    public int PossibleStringCount(string word) {
        var result = word.Aggregate(
            seed: (previous: '\0', count: 0, total: 0),
            func: (item, next) => {
                return item.previous != next ?
                (next, 0, item.total + item.count) :
                (next, item.count + 1, item.total);
            }
        );

        return result.total + result.count + 1;
    }
}