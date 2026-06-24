public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       Dictionary<int,int> tar = new Dictionary<int,int>();
       int[] result = new int[2];
       for(int i = 0 ; i <nums.Length ; i++){
        int ourTarget =target - nums[i];
         if(tar.ContainsKey(ourTarget)){
            
           return [tar[ourTarget],i];
         }
         tar[nums[i]] = i;

       }
       return result;

    }
}
