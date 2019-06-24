/*
Solution number 2 - Hash Table, 1 loop, O(n), space O(n)
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      Hashtable ht = new Hashtable();

      for(int i=0;i<nums.Length;i++){
        int hashKey = target-nums[i];
        if(ht.ContainsKey(hashKey)){                    //if HT contains subtraction compliment
          return new int[] {(int)ht[hashKey], i};
        }
        if( !ht.Contains(nums[i]) ) {                   //Necessary check for duplicate keys before adding
          ht.Add(nums[i], i);
        }
      }
      return new int[] {};                              //Return empty array if no solution
    }
}
