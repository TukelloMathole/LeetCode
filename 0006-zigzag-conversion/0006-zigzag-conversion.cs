public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) {
            return s;
        }

        List<StringBuilder> rows = new List<StringBuilder>();
        for (int i = 0; i < numRows; i++) {
            rows.Add(new StringBuilder());
        }

        int currentRow = 0;
        bool goingDown = false;

        foreach (char c in s) {
            rows[currentRow].Append(c);

            if (currentRow == 0 || currentRow == numRows - 1) {
                goingDown = !goingDown;
            }

            currentRow += goingDown ? 1 : -1;
        }
        StringBuilder result = new StringBuilder();
        foreach (var row in rows) {
            result.Append(row);
        }

        return result.ToString();
    }
}