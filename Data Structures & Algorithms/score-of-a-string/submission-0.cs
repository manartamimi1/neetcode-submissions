public class Solution {
    public int ScoreOfString(string s) {
        int count = 0 ;
        for(int i = 0 ; i <s.Length-1 ; i++){
            count += Math.Abs(s[i]-s[i+1]);
        }
        return count;
    }
}