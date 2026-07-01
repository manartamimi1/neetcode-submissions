public class Solution {
    public int LengthOfLastWord(string s) {
        
        int count = 0;
        string newString = s.Trim();
        int i = newString.Length -1 ;
       while(i >= 0){
       
        if(newString[i] ==' '){
            break;
        }
         count++;
          i--;
         
       }
       return count;
        
    }
}