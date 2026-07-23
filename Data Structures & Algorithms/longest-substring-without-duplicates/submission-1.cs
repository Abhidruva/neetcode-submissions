public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int res = 0;
        int l = 0;
        HashSet<char> charSet = new HashSet<char>();

        for(int r=0;r<s.Length;r++){
            while(charSet.Contains(s[r])){
                charSet.Remove(s[l]);
                l++;
            }
            charSet.Add(s[r]);
            res = Math.Max(res,r-l+1);
        }
        return res;
    }
}
