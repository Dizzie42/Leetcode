/*
  Given a 32-bit signed int, reverse the digits
  --Time of O(log(n)) (36ms < 98.95% of solutions) and space of O(1) (< 100% of submitted solutions)
*/

public class Solution {
    public int Reverse(int myNumber) {
      double result = 0;                                                   //We'll manually handle int32 min/max values

      while(myNumber != 0){
        result = result * 10 + (myNumber%10);
        myNumber /= 10;
      }

      if(result < Int32.MinValue || result > Int32.MaxValue) return 0;    //Manually handle int32 min/max
      return (int) result;
    }
}
