/*
Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.

A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

Example:

Input: "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].

Although the above answer is in lexicographical order, your answer could be in any order you want.


By:  Matt Wilson
Non-recursive solution
*/

public class Solution {
    public IList<string> LetterCombinations(string digits) {
        String[] mapping = new String[]{"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        List<string> result = new List<string>();   //result.Add(string);       //result.ToArray();


        if(digits == null || digits.Length == 0){
            return result;
        } //null case


        letterUtil(result, digits, digits.Length, mapping);
        return result;

    }

    public void letterUtil(List<string> result, String digits, int digitLength , String[] map){
        Queue q = new Queue();
        q.Enqueue("");
        while(q.Count > 0){
            String s = (String)q.Dequeue();
            if(s.Length == digitLength){        //if complete word generated, add to result
                result.Add(s);
            } else {                            //Else add each  queue
                for(int i=0; i<map[digits[s.Length] - '0'].Length; i++){        //- '0' for type conversion to string
                    q.Enqueue(s + map[digits[s.Length] - '0'][i]);              //Loop is O(n)-n = O(n) time
                }
            }
        }
    }
}
