/*
Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.

A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

Example:

Input: "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
Note:

Although the above answer is in lexicographical order, your answer could be in any order you want.


By:  Matt Wilson

*/

public class Solution {
    public IList<string> LetterCombinations(string digits) {
        String[] mapping = new String[]{"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        List<string> result = new List<string>();
        if(digits == null || digits.Length == 0){
            return result;
        } //null case

        letterRecursive(result, digits, "", 0, mapping);
        return result;
    }

    public void letterRecursive(List<string> result, String digits, String current, int index , String[] mapping){
        if(index == digits.Length) {
            result.Add(current);
            return;                 //recursive return case
        }
        String myLetters = mapping[digits[index] - '0'];                                                //convert int to string via - '0' for indexing purposes
        for(int i=0; i<myLetters.Length; i++){
            letterRecursive(result, digits, current+myLetters[i], index+1, mapping);
        }
    }
}
