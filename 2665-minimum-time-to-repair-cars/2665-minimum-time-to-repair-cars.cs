public class Solution
{
	public long RepairCars(int[] ranks, int cars)
	{
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
		long left = 1, right = long.MaxValue;

        foreach (var rank in ranks) {
            if (!dictionary.ContainsKey(rank)) {
                dictionary[rank] = 1;
                right = Math.Min(right, (long)rank * cars * cars);
            } else 
                dictionary[rank]++;
        }

		while(left <= right)
		{
			long middle = left + (right - left) / 2;
            long totalCars = 0;

            foreach (var kvp in dictionary) {
                totalCars += (long)Math.Sqrt(middle / kvp.Key) * kvp.Value;
                if (totalCars >= cars) break;
            }

            if (totalCars >= cars) right = middle - 1;
            else left = middle + 1;
		}

		return left;
	}
}