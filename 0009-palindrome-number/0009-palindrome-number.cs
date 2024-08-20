public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        string xString = x.ToString();

        char[] charArray = xString.ToCharArray();
        Array.Reverse(charArray);

        string reversedString = new string(charArray);

        return xString == reversedString;
    }
}
