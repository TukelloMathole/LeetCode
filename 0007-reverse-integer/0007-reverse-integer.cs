public class Solution {
    public int Reverse(int x) {
       bool isNegative = x < 0;
        
         if (isNegative) {
            x = -x;
        }

        int reversed = 0;
        while (x != 0) {
            int digit = x % 10;
            x /= 10;

            if (reversed > (int.MaxValue - digit) / 10) {
                return 0;
            }

            reversed = reversed * 10 + digit;
        }

        if (isNegative) {
            reversed = -reversed;
        }

        return reversed;
    }
}