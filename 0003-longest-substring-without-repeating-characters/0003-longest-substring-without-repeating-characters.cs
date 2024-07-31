public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        
        int left = 0, right = 0;
        int maxLength = 0;
        HashSet<char> set = new HashSet<char>();
        
        while (right < s.Length) {
            if (!set.Contains(s[right])) {
                set.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, right - left);
            } else {
                set.Remove(s[left]);
                left++;
            }
        }
        
        return maxLength;
    }
}