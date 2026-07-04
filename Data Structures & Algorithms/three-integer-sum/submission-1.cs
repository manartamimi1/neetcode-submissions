public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
       List<List<int>> result = new List<List<int>>();
       Array.Sort(nums);
        for(int i = 0 ; i <nums.Length ; i++){
              if (i > 0 && nums[i] == nums[i - 1]) {
    continue;
}
        int first = i+1 ;
        int second = nums.Length -1 ;
          while(first<second){
         
        if(nums[i]+nums[first]+nums[second] == 0){
           result.Add(new List<int> { nums[i],nums[first],nums[second]});
           first++;
           second--;
          while (first < second && nums[first] == nums[first - 1]) {
                        first++;
                    }

                    // Skip duplicate values for second
                    while (first < second && nums[second] == nums[second + 1]) {
                        second--;
                    }
          }
        else {
            if(nums[i]+nums[first]+nums[second] < 0){
                first++;
            
        }
          if(nums[i]+nums[first]+nums[second] > 0){
                second--;
            
        }
        
         }   
          }
     
        }
        return result;


    }
}