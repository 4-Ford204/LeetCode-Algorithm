public class Spreadsheet {
    public Dictionary<string, int> sheet = new();

    public Spreadsheet(int rows) {

    }
    
    public void SetCell(string cell, int value) {
        sheet[cell] = value;
    }
    
    public void ResetCell(string cell) {
        sheet.Remove(cell);
    }
    
    public int GetValue(string formula) {
        int index = formula.IndexOf('+');
        string x = formula.Substring(1, index - 1);
        string y = formula.Substring(index + 1);

        return 
            (char.IsLetter(x[0]) ? sheet.GetValueOrDefault(x) : int.Parse(x)) +
            (char.IsLetter(y[0]) ? sheet.GetValueOrDefault(y) : int.Parse(y));
    }
}

/**
 * Your Spreadsheet object will be instantiated and called as such:
 * Spreadsheet obj = new Spreadsheet(rows);
 * obj.SetCell(cell,value);
 * obj.ResetCell(cell);
 * int param_3 = obj.GetValue(formula);
 */