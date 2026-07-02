public class Solution {
    public bool IsPalindrome(string s) {
        string newS = s.ToLower(); 
        int left = 0; 
        int right = newS.Length -1;
        while(left < right){
            if(!char.IsLetterOrDigit(newS[left])){
                left++;
                continue;
               
            }
            if(!char.IsLetterOrDigit(newS[right])){
                  right--;
                continue;
              
            }
            if(newS[left] != newS[right]){
                return false;

            }
            right--;
            left++;
            
            
        }
        return true;
    }
}
