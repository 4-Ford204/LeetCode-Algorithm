public class Robot {
    private int Steps { get; set; }
    private int Perimeter { get; set; }
    private int[][] Position { get; set; }
    private string[] Direction { get; set; }

    public Robot(int width, int height) {
        int X = width - 1;
        int Y = height - 1;
        Perimeter = (X + Y) * 2;
        Position = new int[Perimeter][];
        Direction = new string[Perimeter];
        int k = 1;

        for (int i = 1; i <= X; i++) {
            Position[k] = new int[] { i, 0 };
            Direction[k] = "East";
            k++;
        }

        for (int i = 1; i <= Y; i++) {
            Position[k] = new int[] { X, i };
            Direction[k] = "North";
            k++;
        }

        for (int i = X - 1; i >= 0; i--) {
            Position[k] = new int[] { i, Y };
            Direction[k] = "West";
            k++;
        }

        for (int i = Y - 1; i > 0; i--) {
            Position[k] = new int[] { 0, i };
            Direction[k] = "South";
            k++;
        }

        Position[0] = new int[] { 0, 0 };
        Direction[0] = "South";
    }

    public void Step(int num) {
        Steps += num;
    }

    public int[] GetPos() {
        return Position[Steps % Perimeter];
    }

    public string GetDir() {
        return Steps == 0 ? "East" : Direction[Steps % Perimeter];
    }
}