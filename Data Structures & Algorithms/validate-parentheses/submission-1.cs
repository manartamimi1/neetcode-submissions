public class Solution {
    public bool IsValid(string s) {
        Stack<char> valid = new Stack<char>();
        if(s.Length == 1){
            return false;
        }
        for(int i = 0 ; i < s.Length ;i++){
            if(s[i] == '{' || s[i] =='[' ||s[i] =='(' ){
                valid.Push(s[i]);
            }
            else{
                if(valid.Count == 0){
                    return false;
                }

                char top = valid.Pop();
                if((top == '{' && s[i] !='}') ||(top == '[' && s[i] !=']') ||(top == '(' && s[i] !=')')){
                    return false;
                }
    
        }
        }
            return valid.Count == 0;
         
        }

}
