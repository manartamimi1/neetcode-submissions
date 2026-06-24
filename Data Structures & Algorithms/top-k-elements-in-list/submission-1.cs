public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> count = new Dictionary<int,int>();
        
        for(int i = 0 ; i < nums.Length ; i++){
            if(count.ContainsKey(nums[i])){
              count[nums[i]]++;
            }
            else {
                count[nums[i]] =1;
            }
           

        }
        List<int>[] bucket = new List<int>[nums.Length+1];

        foreach(var pair in count){
            int number = pair.Key ;
            int frequency = pair.Value;

            if(bucket[frequency] == null){
              bucket[frequency] = new List<int>();
            }
            bucket[frequency].Add(number);
        }
        List<int> result = new List<int>();
        for(int frequency = bucket.Length -1 ; frequency >= 0 ; frequency--){
            if(bucket[frequency] == null){
                continue;

            }
            foreach(int number in bucket[frequency]){
                result.Add(number);
                if(result.Count ==k){
                    return result.ToArray();
                }
            }

        }
        return result.ToArray();

    }
}
