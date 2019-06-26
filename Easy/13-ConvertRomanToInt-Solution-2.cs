/*
Takes a string of a roman numeral between 1 and 3999 outputs the int value

Time - Faster, just 1 loop through string
Space - No dictionary, no conversions, etc.  less space.
*/

public class Solution {
    public virtual int romValue(char r){        //Returns int value of roman numeral
      if (r == 'I')
        return 1;
      if (r == 'V')
        return 5;
      if (r == 'X')
        return 10;
      if (r == 'L')
        return 50;
      if (r == 'C')
        return 100;
      if (r == 'D')
        return 500;
      if (r == 'M')
        return 1000;
      return -1;
    }

    public int RomanToInt(string s) {
        int result=0;

        for(int i=0;i<s.Length;i++){        //Loop string chars
            int sValue1 = romValue(s[i]);   //get value of current char
            if( i+1 < s.Length){            //If next value exists
                int sValueNext = romValue(s[i+1]);  //Get next value
                if(sValue1 >= sValueNext){  //If current value >= next value
                    result=result+sValue1;  //Just add current value
                } else {                    //else add next value minus current
                    result=result+sValueNext-sValue1;
                    i++;                     //Skip next value
                }
            } else {                        //next value does not exist, result + current value
                result = result + sValue1;
                i++;                        //End loop
            }
        }
        return result;
    }
}
