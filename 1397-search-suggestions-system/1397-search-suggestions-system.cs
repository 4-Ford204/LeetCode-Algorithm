public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        IList<IList<string>> result = new List<IList<string>>();
        Array.Sort(products);

        for (int i = 0; i < searchWord.Length; i++) {
            List<string> searchResult = new List<string>();

            foreach (var product in products) {
                if (product.Length > i && product[i] == searchWord[i])
                    searchResult.Add(product);
            }

            products = searchResult.ToArray();
            result.Add(searchResult.Take(3).ToList());
        }

        return result;
    }
}