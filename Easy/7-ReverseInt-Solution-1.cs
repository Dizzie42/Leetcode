/*
  Given a 32-bit signed int, reverse the digits
  --Used built in functions.
  --Sporadic runtime, generally pretty slow, low memory usage
*/

public class Solution {
    public int Reverse(int myNumber) {
      int absValue, result=0;

      try {
          absValue = Math.Abs(myNumber);                                        //Handle overflow exceptions sloppily
      }
      catch {
          return 0;
      }

/* Do stuff to convert digits to a string */
      char[] digits = absValue.ToString().ToCharArray();
      Array.Reverse(digits);
      string resultString = new string(digits);

/* Try to parse string as a 32 bit INT and return 0 if we fail*/
      bool success = Int32.TryParse(resultString, out result);
      if (!success){
        return 0;
      }

/* Hanle the result if our number was negative*/
      if( absValue != myNumber ){                                               //Num is -
        result *= -1;
      }

      return result;
    }
}
