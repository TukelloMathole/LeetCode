public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        
        int left = 0, right = 0;
        int maxLength = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
        
        while (right < s.Length) {
            if (charIndexMap.ContainsKey(s[right])) {
                left = Math.Max(charIndexMap[s[right]] + 1, left);
            }
            
            charIndexMap[s[right]] = right;
            
            maxLength = Math.Max(maxLength, right - left + 1);
            
            right++;
        }
        
        return maxLength;
    }
}