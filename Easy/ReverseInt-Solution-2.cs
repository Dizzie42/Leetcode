/*
  Given a 32-bit signed int, reverse the digits
  --Time of O(log(n)) and space of O(1)
*/

public class Solution {
    public int Reverse(int x) {
      int r = 0;

      while(x != 0){
        r = r * 10 + (x%10);
        x /= 10;
      }

      if(r < Int32.MinValue || r > Int32.MaxValue) return 0;
      return r;
    }
}
