/*
Take an input of 2 sorted number arrays, assuming neither are empty
Output the median of the two arrays

Strategy:  Combine both arrays to make 1 sorted array, find the median (middle)
    Note:  Median of even number array is 2 middle numbers / 2.

Speed O(n+m) - search cut in half each loop, constant operations on loop
Space(1)        - Constant memory for variables
Note: Faster than 99.5% of solutions, no need to 2nd solution.
*/

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n1 = nums1.Length;
        int n2 = nums2.Length;
        int size = n1+n2;
        int[] combinedArray = new int[size];
        int i=0,j=0,k=0;
        double result = 0;

        //Traverse both arrays until we reach the end of 1 of them
        while( i<n1 && j<n2 ){
            if(nums1[i] < nums2[j]){
                combinedArray[k++] = nums1[i++];                                //add to array position then bump k and i
            } else {
                combinedArray[k++] = nums2[j++];                                //Add to array position then bump k and j
            }
        }
        //Now we add whatever is left from nums1 and nums2
        while(i < n1){
            combinedArray[k++] = nums1[i++];
        }
        while(j < n2){
            combinedArray[k++] = nums2[j++];
        }
        if(size%2 == 1){                                                        //size is odd
            result = combinedArray[size/2];
        } else {                                                                //size is even
            result = (combinedArray[size/2] + combinedArray[(size/2)-1]) / Convert.ToSingle(2);     //ConvertToSingle casts 2 as a float so we get a decimal value
        }
        return result;
    }
}
