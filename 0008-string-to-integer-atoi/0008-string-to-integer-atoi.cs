public class Solution
{
    public int MyAtoi(string s)
    {
        int i = 0, sign = 1, result = 0;
        int n = s.Length;
        
        while (i < n && s[i] == ' ')
        {
            i++;
        }

        if (i < n && (s[i] == '+' || s[i] == '-'))
        {
            sign = (s[i] == '-') ? -1 : 1;
            i++;
        }

        while (i < n && char.IsDigit(s[i]))
        {
            int digit = s[i] - '0';

            if (result > (int.MaxValue - digit) / 10)
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + digit;
            i++;
        }
        return result * sign;
    }
}
