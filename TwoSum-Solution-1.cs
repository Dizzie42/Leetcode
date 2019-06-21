/*
Solution number 1 - Brute Force, O(n^2), space O(1)
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      List<int> res = new List<int>();
        for (int i=0; i<nums.Length; i++){           //Loop on nums array
            for (int j=1; j<nums.Length; j++){      //n^2 - unlucky
              int tmp_res = nums[i]+nums[j];
              if ( tmp_res == target )  {
                //Found a match
                res.Add(i);
                res.Add(j);
                return res.ToArray();
              } else {
                //Not a match, continue;
              }
            }
        }
        return res.ToArray();
    }
}
