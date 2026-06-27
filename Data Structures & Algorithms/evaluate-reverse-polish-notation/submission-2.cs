public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> sur = new Stack<int>();
        int result = 0;
        
        foreach(string token in tokens){
         
            if(token != "*" && token !="+" && token !="-" && token!="/"){
               int number = int.Parse(token);
               sur.Push(number);
            }
            else {
               int top1 = sur.Pop();
               int top2 = sur.Pop();
             if(token == "*"){
                 result = top2 * top1;
                sur.Push(result);
             }
             if(token == "+"){
                 result = top2 + top1;
                sur.Push(result);
             }
             if(token == "-"){
                 result = top2 - top1;
                sur.Push(result);
             }
             if(token == "/"){
                 result = top2 / top1;
                sur.Push(result);
             }
            }
        }
        return sur.Peek();
    }
}
