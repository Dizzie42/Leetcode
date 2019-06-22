/*
Solution number 1 - Brute Force, O(n^2), space O(1)
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i=0; i<nums.Length; i++){           //Loop on nums array
            for (int j=i+1; j<nums.Length; j++){     //j=i+1 because we may not use the same element twice
              if ( nums[i]+nums[j] == target ){     //Found a match
                return new int[] {i, j};
              }
            }
        }
        return new int[] {};
    }
}
