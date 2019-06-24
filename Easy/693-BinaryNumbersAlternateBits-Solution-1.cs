/*
Given a pos. int, check if alternate bits i.e. 2 adjacent bits have different values

Time: O(1)
Space O(1)
*/

public class Solution {
    public bool HasAlternatingBits(int n) {
        string binary = Convert.ToString(n, 2);
        char prevChar = '\0';
        for(int i=0;i<binary.Length;i++){
            if(prevChar == binary[i]){
                return false;
            }
            prevChar = binary[i];
        }
        return true;
    }
}
