public class Solution {
    public string LongestPalindrome(string s) {
        // Check for empty string
        if (s.Length == 0) {
            return "";
        }

        string longest = "";

        // Iterate over each character in the string
        for (int i = 0; i < s.Length; i++) {
            // Find the longest odd-length palindrome with center at i
            string oddPalindrome = ExpandAroundCenter(s, i, i);
            // Update longest if this palindrome is longer
            if (oddPalindrome.Length > longest.Length) {
                longest = oddPalindrome;
            }

            // Find the longest even-length palindrome with center between i and i+1
            string evenPalindrome = ExpandAroundCenter(s, i, i + 1);
            // Update longest if this palindrome is longer
            if (evenPalindrome.Length > longest.Length) {
                longest = evenPalindrome;
            }
        }

        return longest;
    }

    // Helper method to expand around the center
    private string ExpandAroundCenter(string s, int left, int right) {
        // Expand as long as the characters at the left and right indices are equal
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }
        // Return the substring that represents the palindrome
        return s.Substring(left + 1, right - left - 1);
    }
}