/*
Takes a string of a roman numeral between 1 and 3999 outputs the int value
Brute force approach processing string char by char

Time - Slow, loops through entire string
Space - Users lots of space, dictionary of roman numerals and always keeping prev value
*/

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> d = new Dictionary<char, int>();
        d.Add('I', 1);
        d.Add('V', 5);
        d.Add('X', 10);
        d.Add('L', 50);
        d.Add('C', 100);
        d.Add('D', 500);
        d.Add('M', 1000);
        int result = 0;
        string prev = "\0";

        for(int i =0; i<s.Length; i++){         //Loop each char
            if(prev == "I"){
                if(s[i] == 'V') {
                    result += 3;
                    continue;
                }
                if(s[i] == 'X') {
                    result += 8;
                    continue;
                }
            }
            if(prev == "X"){
                if(s[i] == 'L') {
                    result += 30;
                    continue;
                }
                if(s[i] == 'C') {
                    result += 80;
                    continue;
                }
            }
            if(prev == "C"){
                if(s[i] == 'D') {
                    result += 300;
                    continue;
                }
                if(s[i] == 'M') {
                    result += 800;
                    continue;
                }
            }
            result += d[s[i]];            //Add value to result
            prev=s[i].ToString();         //Store prev value for next loop
        }
        return result;
    }
}
