/*
    Given an array nums, are there any elements a,b,c in nums, such that a+b+c =0
        Find all unique triplets in array which give sum of 0

Brute force approach
Time - O(n^3)  triple nested loop,
Space - O(1) 1 list
*/

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> myList = new List<IList<int>>();                      //myList.Add(new List<int> {num1, num2, num3});
        int size = nums.Length;
        for(int i=0; i<size-2;i++){
            for(int j=i+1;j<size-1;j++){
                for(int k=j+1;k<size;k++){
                    if(nums[i] + nums[j] + nums[k] == 0){
                        //Found a match
                        myList.Add(new List<int> { nums[i], nums[j], nums[k]});
                    }
                }
            }
        }
        return myList;
    }
}
