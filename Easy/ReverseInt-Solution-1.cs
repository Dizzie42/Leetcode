/*
  Given a 32-bit signed int, reverse the digits
  --Used built in functions.
  --Sporadic runtime, generally pretty slow, uses very little memory
*/

public class Solution {
    public int Reverse(int x) {
      int y, n, result=0;

      try {
          y = Math.Abs(x);                            //Handle overflow exceptions sloppily
      }
      catch {
          return 0;
      }

/* Do stuff to convert digits to a string */
      char[] digits = y.ToString().ToCharArray();
      Array.Reverse(digits);
      string res_s = new string(digits);

/* Try to parse string as a 32 bit INT and return 0 if we fail*/
      bool success = Int32.TryParse(res_s, out n);
      if (!success){
        return 0;
      }

/* Hanle the result if our number was negative*/
      if( y == x ){                                   //Num is +
        result = Int32.Parse(res_s);
      } else{                                         //Num is -
        result = Int32.Parse(res_s) * (-1);                //Convert string to int
      }

      return result;
    }
}
