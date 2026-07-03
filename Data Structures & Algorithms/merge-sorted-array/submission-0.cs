public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
       int first = m -1;
       int second = n-1;
       int write = nums1.Length - 1 ;
        while(second >=0 && first >=0){
           if(nums1[first] > nums2[second]){
              nums1[write] = nums1[first];
              first--;

           }
           else {
            nums1[write] = nums2[second];
            second--;

           }
            write--;
           
        }
           while (second >= 0) {
            nums1[write] = nums2[second];
            second--;
            write--;
        }
    }
}