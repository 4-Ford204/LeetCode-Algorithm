public class FoodRatings {
    public Dictionary<string, PriorityQueue<(string, int), (int, string)>> queue = new();
    public Dictionary<string, string> cuisine = new();
    public Dictionary<string, int> rating = new();

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) {
        for (int i = 0; i < foods.Length; i++) {
            if (!queue.ContainsKey(cuisines[i]))
                queue.Add(cuisines[i], new PriorityQueue<(string,int), (int,string)>());
            
            queue[cuisines[i]].Enqueue((foods[i], ratings[i]), (-ratings[i], foods[i]));
            cuisine[foods[i]] = cuisines[i];
            rating[foods[i]] = ratings[i];
        }
    }
    
    public void ChangeRating(string food, int newRating) {
        queue[cuisine[food]].Enqueue((food, newRating), (-newRating, food));
        rating[food] = newRating;
    }
    
    public string HighestRated(string cuisine) {
        string result = string.Empty;

        while (queue[cuisine].Count > 0) {
            var (food, rate) = queue[cuisine].Peek();

            if (rating[food] == rate) {
                result = food;
                break;
            }

            queue[cuisine].Dequeue();
        }

        return result;
    }
}

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */