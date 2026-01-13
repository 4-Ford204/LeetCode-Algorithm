public class Solution {
    public double SeparateSquares(int[][] squares) {
        double area = 0, top = 0, bottom = 0;
        double epsilon = 1e-5;
        
        foreach (var square in squares) {
            int y = square[1], l = square[2];
            area += (double)l * l;
            top = Math.Max(top, y + l);
        }

        while (Math.Abs(top - bottom) > epsilon) {
            var middle = (top + bottom) / 2;
            double currentArea = 0;
            
            foreach (var square in squares) {
                int y = square[1], l = square[2];
                if (y < middle) currentArea += l * Math.Min(middle - y, l);
            }

            if (currentArea >= area / 2) top = middle;
            else bottom = middle;
        }

        return top;
    }
}