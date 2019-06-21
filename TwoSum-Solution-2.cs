/*
Solution number 2 - Hash Table, O(n), space O(n)
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      List<int> res = new List<int>();
      Hashtable ht = new Hashtable();

      for(int i=0;i<nums.Length;i++){
        int tmp = target-nums[i];
        if(ht.ContainsKey(tmp)){      //if HT contains subtraction compliment
          return new int[] {(int)ht[tmp], i};
        }
        if( !ht.Contains(nums[i]) ) { //Necessary check for duplicate keys before adding
          ht.Add(nums[i], i);
        }                             //Else already in hash table
      }
      return new int[] {};            //Return empty array if no solution
    }
}
