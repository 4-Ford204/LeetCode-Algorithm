public class Solution {
    public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes) {
        int maxWorkerTime = int.MinValue;

        foreach (var workerTime in workerTimes)
            maxWorkerTime = Math.Max(maxWorkerTime, workerTime);

        long minTime = 1;
        long maxTime = (long)maxWorkerTime * mountainHeight * (mountainHeight + 1) / 2;

        while (minTime < maxTime) {
            long averageTime = (minTime + maxTime) / 2;
            long reduceHeight = 0;

            foreach (var workerTime in workerTimes) {
                reduceHeight += (-1 + (long)Math.Sqrt(1 + 4 * 2 * averageTime / workerTime)) / 2;
                if (reduceHeight >= mountainHeight) break;
            }

            if (reduceHeight >= mountainHeight) maxTime = averageTime;
            else minTime = averageTime + 1;
        }

        return minTime;
    }
}