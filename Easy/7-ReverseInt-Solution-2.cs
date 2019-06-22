/*
  Given a 32-bit signed int, reverse the digits
  --Time of O(log(n)) (36ms < 98.95% of solutions) and space of O(1) (< 100% of submitted solutions)
*/

public class Solution {
    public int Reverse(int x) {
      double r = 0;                                             //We'll manually handle int32 min/max values

      while(x != 0){
        r = r * 10 + (x%10);
        x /= 10;
      }

      if(r < Int32.MinValue || r > Int32.MaxValue) return 0;    //Manually handle int32 min/max
      return (int) r;
    }
}
