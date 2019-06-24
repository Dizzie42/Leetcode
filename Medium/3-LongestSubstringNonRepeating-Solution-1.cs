/*
Given a string, find the length of the longest substring without repeating chars
Using a new class definition because why not

Time: O(n) each character visited twice
Space: O(n)
*/

//keep looping until we see a duplicate of our current

public class substring {
    public int longestSubstring(string s) {
        int len = s.Length;
        HashSet<int> ht = new HashSet<int>();                 //Unique values
        int result=0, i=0, j=0;
        while(i<len && j<len){
            if(!ht.Contains(s[j])){
                ht.Add(s[j++]);
                result = Math.Max(result, j-i);
            }else {
                ht.Remove(s[i++]);
            }
        }
        return result;
    }
}


public class Solution {
    substring result = new substring();
    public int LengthOfLongestSubstring(string s) {
        return result.longestSubstring(s);
    }
}
