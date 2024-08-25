public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (var num in nums1) {
            if (counts.ContainsKey(num)) {
                counts[num]++;
            } else {
                counts[num] = 1;
            }
        }
        
        List<int> result = new List<int>();
        
        foreach (var num in nums2) {
            if (counts.ContainsKey(num) && counts[num] > 0) {
                result.Add(num);
                counts[num]--;
            }
        }
        
        return result.ToArray();
    }
}