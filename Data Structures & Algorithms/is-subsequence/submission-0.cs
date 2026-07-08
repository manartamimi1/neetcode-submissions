public class Solution {
    public bool IsSubsequence(string s, string t) {
        int first = 0;
        int second = 0 ;
        
        while(first < s.Length && second < t.Length){
            if(s[first] ==t[second]){
                first++;
                second++;
            }
            else{
                if(s[first] != t[second]){
                    second++;
                }
            }
            

        }
        return first == s.Length;
    }
}