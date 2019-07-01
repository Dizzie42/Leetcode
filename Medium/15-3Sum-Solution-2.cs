/*
    Given an array nums, are there any elements a,b,c in nums, such that a+b+c =0
        Find all triplets in array which give sum of 0
DOES NOT RETURN UNIQUE TRIPLETS, Will repeat a set given the right input, for example {-4, -1, -1, 0, 1, 2}

Time - O(n^2) - Time for the sort + our loop
Space - O(1) - Space for list and sorted array
*/

//

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> myList = new List<IList<int>>();                      //myList.Add(new List<int> {num1, num2, num3});
        Array.Sort(nums);                                                       //insertion sort if < 16, otherwise 2*log(size), use Heapsort, otherwise use Quicksort.
        int size = nums.Length;
        for(int i=0;i<size;i++){
            int left = i + 1;
            int right = size - 1;
            int curr = nums[i];

            while(left < right){
                if(curr + nums[left] + nums[right] == 0){
                    myList.Add(new List<int> { curr, nums[left], nums[right]});
                    left++;
                    right--;
                } else if(curr + nums[left] + nums[right] < 0){
                    left++;
                } else{
                    right --;
                }
            }
        }
        return myList.Distinct();
    }
}
