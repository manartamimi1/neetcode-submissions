public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string prefix = strs[0];

        for(int i = 1 ; i < strs.Length ; i++){
            string result = "";
           string current = strs[i];

           int limit = Math.Min(prefix.Length , current.Length);
           for(int j = 0 ; j <limit ; j++){
            
            if(prefix[j] != current[j]){
                break;
            }
            result+=prefix[j];
           }
           prefix = result;
           if(prefix ==""){
            return "";
           }
        }
        return prefix;
    }
}