public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
         int postfix = 1;
          int prefix = 1;
        for(int i = 0 ; i < nums.Length ; i++){
           
            result[i] = prefix ;
            prefix *= nums[i];

        }
        for(int i = result.Length -1 ; i >=0 ; i--){
           
             result[i] *= postfix;
             postfix *= nums[i];
        }

         return result;
    }
}
